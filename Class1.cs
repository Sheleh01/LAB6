﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LABAAAA6
{
    public partial class Ball : tennis, IAmForTypography
    {


        public bool ForTyp()
    {
        this.IsForTyp = true;
        return true;
    }
}

}
