﻿using System.Text.Json;

namespace MotoAPp.Entities.Extensions
{
    public static class EntityExtension
    {
        public static T? Copy<T>(this T itemToCopy) where T : IEntity 
        {
            var json = JsonSerializer.Serialize<T>(itemToCopy);
            return JsonSerializer.Deserialize<T>(json);
        }
    }
}
