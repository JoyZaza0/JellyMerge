﻿using System.Reflection;

namespace Watermelon
{
    public abstract class FieldDrawer
    {
        public abstract void DrawField(UnityEngine.Object target, FieldInfo field);
    }
}
