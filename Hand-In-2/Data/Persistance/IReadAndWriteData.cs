﻿using System;
 using System.Collections.Generic;

namespace Hand_In_2.Data.Persistance
{
    public interface IReadAndWriteData <T> 
    {
        public IList<T> ReadData();
        public void SaveChanges(string json);
    }
}