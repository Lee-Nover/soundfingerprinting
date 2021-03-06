﻿// Sound Fingerprinting framework
// git://github.com/AddictedCS/soundfingerprinting.git
// Code license: CPOL v.1.02
// ciumac.sergiu@gmail.com
using System;
using System.Runtime.Serialization;

namespace Soundfingerprinting.DbStorage
{
    /// <summary>
    ///   Exception class for Entity Library
    /// </summary>
    [Serializable]
    public class FingerprintEntityException : Exception
    {
        #region Constructors

        /// <summary>
        ///   Default constructor
        /// </summary>
        public FingerprintEntityException()
        {
        }

        /// <summary>
        ///   Constructor
        /// </summary>
        /// <param name = "message">Exception message</param>
        public FingerprintEntityException(string message) : base(message)
        {
        }

        /// <summary>
        ///   Constructor
        /// </summary>
        /// <param name = "message">Exception message</param>
        /// <param name = "innerException">Inner exception</param>
        public FingerprintEntityException(string message, Exception innerException) : base(message, innerException)
        {
        }

        /// <summary>
        ///   Constructor
        /// </summary>
        /// <param name = "info">Serialization info</param>
        /// <param name = "ctx">Serialization context</param>
        protected FingerprintEntityException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }

        #endregion
    }
}