﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniFileBase
{
    public interface IButton : IRunnable
    {

        char Id { get; set; }

        string Caption { get; set; }
    }
}
