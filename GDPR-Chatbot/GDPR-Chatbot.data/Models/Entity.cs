﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GDPR_Chatbot.data
{
    public class Entity
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public string Content { get; set; }
        public EntityQuestion Question {get; set;}
    }
}