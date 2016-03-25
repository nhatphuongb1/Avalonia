﻿// Copyright (c) The Perspex Project. All rights reserved.
// Licensed under the MIT license. See licence.md file in the project root for full license information.

namespace Perspex.Logging
{
    public interface ILogSink
    {
        void Log(
            LogEventLevel level,
            string area,
            object source,
            string messageTemplate, 
            params object[] propertyValues);
    }
}
