﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VidlyMVCWebApplication.Models
{
    public class Movie
    {
        public int Id { get;set;}
        public string Name { get;set;}


        public  Movie(int Id,string Name)
        {
            this.Id=Id;
            this.Name=Name;
        }

        public Movie()
        {

        }
    }
}