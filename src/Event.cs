﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibEventManagerCSharp
{
    public class Event
    {
        private Boolean cancelled = false;

        public void Cancel()
        {
            cancelled = true;
        }

        public Boolean Cancelled()
        {
            return cancelled;
        }

        protected internal virtual void OnEventPre() { }

        protected internal virtual void OnEventPost(ref bool remove) { }
    }
}
