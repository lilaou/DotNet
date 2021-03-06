﻿using System;

namespace ObserverDemo
{
    public class Doer
    {

        public event EventHandler<string> AfterDoSomethingWith;
        public event EventHandler<Tuple<string, string>> AfterDoMore;

        private string data = string.Empty;

        public void DoSomethingWith(string data)
        {
            this.data = data;
            OnAfterDoSomethingWith(this.data);
        }

        public void DoMore(string appendData)
        {
            this.data += appendData;
            OnAfterDoMore(this.data, appendData);
        }

        private void OnAfterDoSomethingWith(string data)
        {
            if (this.AfterDoSomethingWith != null)
                this.AfterDoSomethingWith(this, data);
        }

        private void OnAfterDoMore(string completeData, string appendedData)
        {
            if (this.AfterDoMore != null)
                this.AfterDoMore(this, Tuple.Create(completeData, appendedData));
        }

    }
}
