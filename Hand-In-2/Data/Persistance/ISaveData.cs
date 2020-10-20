﻿using System.Collections.Generic;

namespace Hand_In_2.Data.Persistance
{
    public interface ISaveData
    {
        public IList<T> ReadData<T>(enums e);
        public void SaveChanges(enums e, string json);
    }
}