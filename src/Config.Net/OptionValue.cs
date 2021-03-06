﻿using System;

namespace Config.Net
{
   class OptionValue
   {
      public object RawValue;

      public DateTime Updated;

      public bool IsExpired(TimeSpan ttl)
      {
         if (ttl == TimeSpan.Zero) return true;

         return (DateTime.UtcNow - Updated) > ttl;
      }

      public void Update<T>(T value)
      {
         RawValue = value;
         Updated = DateTime.UtcNow;
      }
   }
}
