using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns
{
    class Logger
    {
        private Logger()
        {

        }

        private static Logger logger;

        public static Logger GetInstance
        {
            get
            {
                if (logger == null)
                {
                    logger = new Logger();
                }
                return logger;
            }
        }


    }
}
