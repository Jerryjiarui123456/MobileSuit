﻿using System;
using System.Threading.Tasks;
using PlasticMetal.MobileSuit.Core;

namespace PlasticMetal.MobileSuit.ObjectModel
{
    /// <summary>
    ///     A Logger can be assigned once
    /// </summary>
    public interface IAssignOnceLogger : ILogger, IAssignOnce<ILogger>
    {
    }

    /// <summary>
    ///     A Logger can be assigned once
    /// </summary>
    public class AssignOnceLogger : IAssignOnceLogger, IDisposable
    {
        /// <summary>
        ///     The real logger used
        /// </summary>
        protected ILogger Element { get; private set; } = ILogger.OfEmpty();

        /// <inheritdoc />
        public void LogDebug(string content)
        {
            Element.LogDebug(content);
        }

        /// <inheritdoc />
        public void LogCommand(string content)
        {
            Element.LogCommand(content);
        }

        /// <inheritdoc />
        public void LogTraceBack(TraceBack content, object? returnValue = null)
        {
            Element.LogTraceBack(content, returnValue);
        }

        /// <inheritdoc />
        public void LogException(string content)
        {
            Element.LogException(content);
        }

        /// <inheritdoc />
        public void LogException(Exception content)
        {
            Element.LogException(content);
        }

        /// <inheritdoc />
        public Task LogDebugAsync(string content)
        {
            return Element.LogDebugAsync(content);
        }

        /// <inheritdoc />
        public Task LogCommandAsync(string content)
        {
            return Element.LogCommandAsync(content);
        }

        /// <inheritdoc />
        public Task LogTraceBackAsync(TraceBack content, object? returnValue = null)
        {
            return Element.LogTraceBackAsync(content, returnValue);
        }

        /// <inheritdoc />
        public Task LogExceptionAsync(string content)
        {
            return Element.LogExceptionAsync(content);
        }

        /// <inheritdoc />
        public Task LogExceptionAsync(Exception content)
        {
            return Element.LogExceptionAsync(content);
        }

        /// <inheritdoc />
        public string FilePath => Element.FilePath;

        /// <inheritdoc />
        public void Dispose()
        {
            Element.Dispose();
        }

        /// <inheritdoc />
        public void Assign(ILogger t)
        {
            Element.Dispose();
            Element = t;
        }
    }
}