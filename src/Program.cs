﻿using System.ServiceProcess;

namespace MenuSelector
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        static void Main()
        {
            var servicesToRun = new ServiceBase[] 
			{ 
				new Scheduler() 
			};
            ServiceBase.Run(servicesToRun);
        }
    }
}
