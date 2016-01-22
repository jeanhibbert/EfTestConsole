namespace EfTestConsole.Helpers
{
    using System;
    using System.Diagnostics;

    public class MeasureUtil : IDisposable
    {
        #region Fields

        private readonly Stopwatch _stopWatch;

        #endregion

        #region Constructors and Destructors

        public MeasureUtil(string name)
        {
            Console.WriteLine("--- {0} ---", name);
            this._stopWatch = new Stopwatch();
            this._stopWatch.Start();
        }

        #endregion

        #region Public Methods and Operators

        public void Dispose()
        {
            this._stopWatch.Stop();
            TimeSpan ts = this._stopWatch.Elapsed;

            string elapsedTime = String.Format(
                "{0:00}:{1:00}:{2:00}.{3:00}", ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds / 10);
            Console.WriteLine(elapsedTime, "RunTime");
            Console.WriteLine("------");
        }

        #endregion
    }
}