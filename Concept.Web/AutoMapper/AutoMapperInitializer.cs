﻿using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Concept.Web.AutoMapper
{
    public class AutoMapperInitializer
    {
        public static void Initialize()
        {
            Mapper.Initialize(cfg =>

                cfg.AddProfiles(new[] { "Concept.Bll", "Concept.Web" })
            );
        }
    }
}