using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using Microsoft.Practices.Unity;

namespace Paralect.App.Web
{
    public class HttpApplicationUnityContext
    {
        private const String UnityContextKey = "UnityContext";

        private static Object _lock = new Object();

        private static IUnityContainer _current;

        public static IUnityContainer Current
        {
            get
            {
                IUnityContainer unity;

                if (HttpContext.Current != null)
                    unity = HttpContext.Current.Application[UnityContextKey] as IUnityContainer;
                else
                    unity = _current;

                if (unity == null)
                {
                    lock (_lock)
                    {
                        if (unity == null)
                        {
                            unity = new UnityContainer();

                            if (HttpContext.Current != null)
                                HttpContext.Current.Application[UnityContextKey] = unity;
                            else
                                _current = unity;
                        }
                    }
                }

                return unity;
            }
        }
    }
}
