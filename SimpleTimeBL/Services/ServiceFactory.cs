using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleTimeBL.Services
{
    public sealed class ServiceFactory
    {
        #region Fields

        private static readonly ServiceFactory _factory = new ServiceFactory();

        #endregion

        #region Properties

        public static ServiceFactory Factory
        {
            get { return _factory; }
        }

        #endregion

        #region Constructors

        static ServiceFactory()
        {
        }

        ServiceFactory()
        {
        }

        #endregion
    }
}
