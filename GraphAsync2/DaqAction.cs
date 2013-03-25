using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NationalInstruments.DAQmx;

namespace GraphAsync1
{
    class DaqAction
    {
        private NationalInstruments.DAQmx.Task myTask;

        // Reads input values from DAQ,
        // which DAQs to read from is controlled from Settings1.Default.DAQ_CreateVoltageChannel_AI_chans
        public void Read(ref double[] currentValue)
        {
            try
            {
                //Create a new task
                using (myTask = new NationalInstruments.DAQmx.Task())
                {
                    //Create a virtual channel
                    
                    //"Dev1/ai0,Dev1/ai1"
                    myTask.AIChannels.CreateVoltageChannel(Settings1.Default.DAQ_CreateVoltageChannel_AI_chans, "",
                        (AITerminalConfiguration.Rse), 0.0,
                        5.0, AIVoltageUnits.Volts);

                    AnalogMultiChannelReader reader = new AnalogMultiChannelReader(myTask.Stream);

                    //Verify the Task
                    myTask.Control(TaskAction.Verify);

                    //Initialize the table
                    //InitializeDataTable(myTask.AIChannels,ref dataTable); 
                    //acquisitionDataGrid.DataSource=dataTable;

                    //Plot Multiple Channels to the table
                    double[] data = reader.ReadSingleSample();
                    currentValue = data;
                    //dataToDataTable(data,ref dataTable);
                }
            }
            catch (DaqException exception)
            {
                System.Windows.Forms.MessageBox.Show(exception.Message);
                throw;
            }
        }

        public void UpdateDaqOut(int AOchannel, double voltOut)
        {
            string AOchannel_s = "Dev1/ao0";

            switch (AOchannel)
            {
                case 0:
                    AOchannel_s = "Dev1/ao0";
                    break;
                case 1:
                    AOchannel_s = "Dev1/ao1";
                    break;
                case 2:
                    //AOchannel_s = "Dev1/ao1";
                    AOchannel_s = "Dev1/ao0";
                    break;
                case 3:
                    //AOchannel_s = "Dev1/ao1";
                    AOchannel_s = "Dev1/ao1";
                    break;
            }
            
            try
            {
                using (myTask = new NationalInstruments.DAQmx.Task())
                {
                    myTask.AOChannels.CreateVoltageChannel(AOchannel_s, "aoChannel",
                        0.0, 5.0, AOVoltageUnits.Volts);
                    AnalogSingleChannelWriter writer = new AnalogSingleChannelWriter(myTask.Stream);
                    writer.WriteSingleSample(true, voltOut);
                }
            }
            catch (DaqException ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
                throw;
            }
        }
    }
}
