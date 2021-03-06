﻿using System;
using System.Collections.Generic;
using System.Text;

namespace GenericDataFlow.Interfaces
{
    public interface IDataFlow<T> where T : class
    {
        T RunFlow(T input);
        void AddBlock(IBlock<T> block);
    }


}
