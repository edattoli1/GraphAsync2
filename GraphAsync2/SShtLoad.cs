﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Spreadsheet;

namespace GraphAsync1
{
    class SShtLoad
    {
        private const string sheetName = "Sheet1";
        private List<string[]> tableLoad = new List<string[]>();

        public bool[] LoadMFCstate(string fileName)
        {
            bool[] returnArray = new bool[Settings1.Default.MFCcontrol_numMFCs];

            using (SpreadsheetDocument document = SpreadsheetDocument.Open(fileName, false))
            {
                WorkbookPart wbPart = document.WorkbookPart;

                // Find the sheet with the supplied name, and then use that Sheet object
                // to retrieve a reference to the appropriate worksheet.
                Sheet theSheet = wbPart.Workbook.Descendants<Sheet>().
                  Where(s => s.Name == sheetName).FirstOrDefault();

                if (theSheet == null)
                {
                    throw new ArgumentException("sheetName");
                }

                // Retrieve a reference to the worksheet part, and then use its Worksheet property to get 
                // a reference to the cell whose address matches the address you've supplied:
                WorksheetPart wsPart = (WorksheetPart)(wbPart.GetPartById(theSheet.Id));

                int numCols = Settings1.Default.MFCcontrol_numMFCs + 1;

                string[] currentRow = new string[numCols];

                currentRow = XLGetRow(numCols, 1.ToString(), wsPart);

                for (int i = 1; i <= Settings1.Default.MFCcontrol_numMFCs; i++)
                {
                    if (Convert.ToDouble(currentRow[i]) > 0)
                        returnArray[i - 1] = true;
                    else
                        returnArray[i - 1] = false;
                }
            }

            return returnArray;

        }

        public int[] LoadMFCmaxFlows(string fileName)
        {
            int[] returnArray = new int[Settings1.Default.MFCcontrol_numMFCs];

            using (SpreadsheetDocument document = SpreadsheetDocument.Open(fileName, false))
            {
                WorkbookPart wbPart = document.WorkbookPart;

                // Find the sheet with the supplied name, and then use that Sheet object
                // to retrieve a reference to the appropriate worksheet.
                Sheet theSheet = wbPart.Workbook.Descendants<Sheet>().
                  Where(s => s.Name == sheetName).FirstOrDefault();

                if (theSheet == null)
                {
                    throw new ArgumentException("sheetName");
                }

                // Retrieve a reference to the worksheet part, and then use its Worksheet property to get 
                // a reference to the cell whose address matches the address you've supplied:
                WorksheetPart wsPart = (WorksheetPart)(wbPart.GetPartById(theSheet.Id));

                int numCols = Settings1.Default.MFCcontrol_numMFCs + 1;

                string[] currentRow = new string[numCols];

                currentRow = XLGetRow(numCols, 2.ToString(), wsPart);

                for (int i = 1; i <= Settings1.Default.MFCcontrol_numMFCs; i++)
                {
                    returnArray[i - 1] = Convert.ToInt32(currentRow[i]);
                }
            }

            return returnArray;

        }
        
        public List<string[]> Load(string fileName)
        {
            using (SpreadsheetDocument document = SpreadsheetDocument.Open(fileName, false))
            {
                WorkbookPart wbPart = document.WorkbookPart;

                // Find the sheet with the supplied name, and then use that Sheet object
                // to retrieve a reference to the appropriate worksheet.
                Sheet theSheet = wbPart.Workbook.Descendants<Sheet>().
                  Where(s => s.Name == sheetName).FirstOrDefault();

                if (theSheet == null)
                {
                    throw new ArgumentException("sheetName");
                }

                // Retrieve a reference to the worksheet part, and then use its Worksheet property to get 
                // a reference to the cell whose address matches the address you've supplied:
                WorksheetPart wsPart = (WorksheetPart)(wbPart.GetPartById(theSheet.Id));

                int numCols = Settings1.Default.MFCcontrol_numMFCs + 1;
                
                //start at this row in the spreadsheet file
                int rowIterator = 4;

                string[] currentRow = new string[numCols];

                while (true)
                {
                    currentRow = XLGetRow(numCols, rowIterator.ToString(), wsPart);

                    // stop loading spreadsheet once you hit -1 in the first column of a row
                    if (Convert.ToDouble(currentRow[0]) < 0)
                    {
                        break;
                    }

                    tableLoad.Add(currentRow);
                    rowIterator++;
                }
            }

            return tableLoad;
        }


        public static string[] XLGetRow(int numCols, string sSheetRowNum, WorksheetPart wsPart)
        {
            string[] returnList = new string[numCols];
            int returnListIterator = 0;

            for (char c = 'A'; c <= 'E'; c++)
            {
                returnList[returnListIterator] = XLGetCellValue(wsPart, c + sSheetRowNum);
                returnListIterator++;
            }

            return returnList;
        }

        // XLGetCellValue returns a string containing the cell value at certain cell (addressName)
        // This function does not work on cells that contain strings

        public static string XLGetCellValue(WorksheetPart wsPart, string addressName)
        {
            string value = null;


            Cell theCell = wsPart.Worksheet.Descendants<Cell>().
              Where(c => c.CellReference == addressName).FirstOrDefault();

            // If the cell doesn't exist, return an empty string:
            if (theCell != null)
            {
                //value = theCell.InnerText;

                /*  To retrieve just the value */
                value = theCell.CellValue.InnerText;


                // If the cell represents an integer number, you're done. 
                // For dates, this code returns the serialized value that 
                // represents the date. The code handles strings and booleans
                // individually. For shared strings, the code looks up the corresponding
                // value in the shared string table. For booleans, the code converts 
                // the value into t he words TRUE or FALSE.
                if (theCell.DataType != null)
                {
                    switch (theCell.DataType.Value)
                    {
                        //case CellValues.SharedString:
                        //    // For shared strings, look up the value in the shared strings table.
                        //    var stringTable = wbPart.GetPartsOfType<SharedStringTablePart>().FirstOrDefault();
                        //    // If the shared string table is missing, something's wrong.
                        //    // Just return the index that you found in the cell.
                        //    // Otherwise, look up the correct text in the table.
                        //    if (stringTable != null)
                        //    {
                        //        value = stringTable.SharedStringTable.ElementAt(int.Parse(value)).InnerText;
                        //    }
                        //    break;

                        case CellValues.Boolean:
                            switch (value)
                            {
                                case "0":
                                    value = "FALSE";
                                    break;
                                default:
                                    value = "TRUE";
                                    break;
                            }
                            break;
                    }
                }
            }

            return value;
        }




    }
}
