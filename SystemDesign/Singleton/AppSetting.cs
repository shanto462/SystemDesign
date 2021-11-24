using System;
using System.Collections.Generic;
using System.Text;

namespace Solve.Singleton
{
    public class AppSetting
    {
        public static Lazy<AppSetting> Instance = new Lazy<AppSetting>(() => new AppSetting());

        private AppSetting()
        {

        }
    }
}
