using System.Diagnostics;
using System;
using System.IO;
namespace JTejero
{
    public class Q089
    {
        static TraceSource ts = new TraceSource("Contoso, ",
            //A - 1
            SourceLevels.ActivityTracing //Deja pasar los eventos Stop, Start, Suspend, Transfer y Resume.
            );

        public void DoWork()
        {
            // For Test purpose only
            Stream myTracerFile = File.Create("TracertFileWCF.etl");
            ts.Listeners.Add(new TextWriterTraceListener(myTracerFile));
            ts.Listeners.Add(new TextWriterTraceListener(Console.Out));
            // End For...
            var originalId = Trace.CorrelationManager.ActivityId;
            var guid = Guid.NewGuid();
            try
            {
                // For test purpose only
                ts.TraceTransfer(1, "Original Activity", originalId);
                //End For...
                // B - 1 
                ts.TraceTransfer(1, "Changing Activity", guid);
                Trace.CorrelationManager.ActivityId = guid;
                // C - 2
                ts.TraceEvent(TraceEventType.Start, 0, "Start");
            }
            finally
            {
                //For purpose test only
                Trace.CorrelationManager.ActivityId = originalId;
                //End purpose test
                //D - 2    
                ts.TraceTransfer(1, "Changing Activity", originalId);
                //E - 2
                ts.TraceEvent(TraceEventType.Stop, 0, "Stop");
                // For Test purpose only
                ts.Flush();
                myTracerFile.Close();
                // End For...
            }
            // A - 2
            //SourceLevels.Information; // Deja pasar los eventos Critical, Error, Warning e Information
            // A - 3
            //SourceLevels.Verbose; // Deja pasar los eventos Critical, Error, Warning, Information y Verbose. 
            // A - 4
            //SourceLevels.Critical; // Deja pasar sólo los eventos Critical.
            // B - 2 
            //ts.TraceEvent(TraceEventType.Start, 0, "Start"); 
            // B - 3 
            //ts.TraceTransfer(1, "Changing Activity", originalId);
            // B - 4
            //ts.TraceInformation("Start");
            // C - 1
            // ts.TraceTransfer(1, "Changing Activity", guid);
            // C - 3 
            //ts.TraceTransfer(1, "Changing Activity", originalId);
            // C - 4
            //ts.TraceInformation("Start");
            // D - 1 
            //ts.TraceTransfer(1, "Changing Activity", guid);
            // D - 3 
            //ts.TraceInformation("Stop");
            // E - 1 
            //ts.TraceTransfer(1, "Changing Activity", guid);
            // E - 3 
            //ts.TraceInformation("Stop");
        }
    }
}