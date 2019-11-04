using System;

namespace Samples
{
    partial class Sample
    {
        static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                Console.WriteLine("Sample to run:");
                RunSample(Console.ReadLine());
            }
            else
            {
                foreach (string sampleName in args)
                {
                    RunSample(sampleName);
                }
            }
            Console.WriteLine("Press Enter to Exit");
            Console.ReadLine();
        }

        static void RunSample(string sampleName)
        {
            switch (sampleName)
            {
                case "SendEmailToMultipleRecipients":
                    SendEmailToMultipleRecipients();
                    break;
                case "SendEmailToSingleRecipient":
                    SendEmailToSingleRecipient();
                    break;
                default:
                    Console.WriteLine("Unrecognized sample: " + sampleName);
                    break;
            }
        }
    }
}