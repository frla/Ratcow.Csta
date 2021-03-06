﻿/* Ratcow.Csta is an ECMA-323/ECMA-354 XML API integration for MS.Net.
 * Copyright (C) 2018 Ratcow Software and Matt Emson. 
 * 
 * This software is dual licensed. It may be freely used under the GPL3,
 * but any for any proprietary commercial use, it must me licensed under 
 * the terms of a commercial license, and may only be included in any 
 * release after the appropriate fees have been paid.
 * 
 * The GPL3 license is as follows:
 *
 
    This file is part of the Ratcow.Csta namespace..

    Ratcow.Csta is free software: you can redistribute it and/or modify
    it under the terms of the GNU General Public License as published by
    the Free Software Foundation, either version 3 of the License, or
    (at your option) any later version.

    Ratcow.Csta is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU General Public License for more details.

    You should have received a copy of the GNU General Public License
    along with Ratcow.Csta.  If not, see <http://www.gnu.org/licenses/>.
 *
 */


using System;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml;
using System.Linq;

namespace Ratcow.Csta.Engine.Core
{
    using Serialization;
    using Core;
    using Core.Responses;
    using Logs.Logging;


    public class TcpCommsServer : TcpCommsBase
    {
        readonly ILog logger = LogProvider.For<TcpCommsServer>();

        public TcpCommsServer(IInvokeIdService invokeIdService = null) : base(invokeIdService)
        {
        }

        public void SendResponse<T>(string invokeId, T request)
        {
            //TODO - this needs more protection.
            WriteXmlMessage(invokeId, SerializationHelper.Serialize(request));
        }

        public void SendResponse<T>(int invokeId, T request)
        {
            var invokeIdString = invokeId.GetString();
            //TODO - this needs more protection.
            WriteXmlMessage(invokeIdString, SerializationHelper.Serialize(request));
        }

        ///// <summary>
        ///// This is almost identical to the example project
        ///// </summary>
        //public void RawSendResponse(string invokeId, string request)
        //{            
        //    ///*
        //    // * According to CSTA-ECMA 323 Standard ANNEX G
        //    // * Section G.2.  CSTA XML without SOAP
        //    // * 
        //    // * The Header is  8 bytes long.
        //    // * | 1 | 2 | 3 | 4 | 5 | 6 | 7 | 8 |   
        //    // * |VERSION|LENGTH |   INVOKE ID   |   XML PAYLOAD
        //    // * 
        //    // * VERSION: 2 bytes
        //    // * LENGTH: 2 bytes information that contains the total size 
        //    // * (XML payload + Header)
        //    // * INVOKE ID: 4 bytes.  
        //    // * 
        //    // */

        //    //if (writer == null)
        //    //{
        //    //    return;
        //    //}

        //    //try
        //    //{
        //    //    // HEADER : VERSION
        //    //    var version = IPAddress.HostToNetworkOrder((short)0);
        //    //    var verHeader = BitConverter.GetBytes(version);

        //    //    writer.Write(verHeader); // using the BinaryWriter

        //    //    // HEADER : LENGTH (PAYLOAD + HEADER(8))
        //    //    var totalLength = IPAddress.HostToNetworkOrder((short)(request.Length + TcpCommsConstants.XML_HEADER_LEN));
        //    //    var lengthHeader = BitConverter.GetBytes(totalLength);
        //    //    writer.Write(lengthHeader); // using the BinaryWriter

        //    //    // HEADER : INVOKE ID
        //    //    var invokeIdByte = ToByteArray(invokeId);
        //    //    writer.Write(invokeIdByte); // using the BinaryWriter

        //    //    // MESSAGE : XML PAYLOAD
        //    //    var requestMessage = ToByteArray(request);
        //    //    writer.Write(requestMessage); // using the BinaryWriter
        //    //}
        //    //catch (Exception e)
        //    //{
        //    //    Console.WriteLine("Exception occurred in SendRequest.\n");
        //    //    Console.WriteLine(e.Message);
        //    //}
        //    //finally
        //    //{
        //    //    writer.Flush();
        //    //}
        //}

        ///// <summary>
        ///// This is almost identical to the example project
        ///// </summary>
        //public (string Request, int InvokeId) ReadXMLMessage(bool addWait = false)
        //{
        //    /*
        //     * Removing the Header information.
        //     * 
        //     * | 1 | 2 | 3 | 4 | 5 | 6 | 7 | 8 |   
        //     *  VERSION|LENGTH |   INVOKE ID   |   XML PAYLOAD
        //     * 
        //     * VERSION: 2 bytes
        //     * LENGTH: 2 bytes
        //     * INVOKE ID: 4 bytes
        //     */

        //    /* In most of the cases application starts reading the xml response immediately 
        //     * after sending XML request.. so waiting for some time to get the complete response. 
        //     */
        //    if (addWait)
        //    {
        //        Thread.Sleep(150);
        //    }

        //    try
        //    {
        //        // Skip the CSTA version in byte 1, 2
        //        reader.ReadBytes(TcpCommsConstants.VERSION_LEN);
        //        // Read the length of the response in byte 3, 4
        //        var requestLength = (long)IPAddress.NetworkToHostOrder(reader.ReadInt16());
        //        // String to store the response ASCII representation.
        //        var data = new byte[requestLength];

        //        // Read ahead in the header. Invoke ID: byte 5,6,7,8	
        //        var requestInvokeIdString = new string(reader.ReadChars(TcpCommsConstants.INVOKE_ID_LEN));
        //        if (!int.TryParse(requestInvokeIdString, out int requestInvokeId))
        //        {
        //            requestInvokeId = -1;//????
        //        }

        //        // Read the XML Payload which is found at offset 8.
        //        // The length of XML payload = XML message length - XML header length.
        //        var totalbytesremaining = data.Length - TcpCommsConstants.XML_HEADER_LEN;
        //        while (totalbytesremaining > 0)
        //        {
        //            //This was a horrible bug in the original example code - we just waitied 
        //            //a bit for every event, so if the data was less than expected, the 
        //            //XML became b0rked. If you remove this 150 milisecond "hedge" longer 
        //            //data messages fail horribly to arrive.
        //            var bytes = reader.Read(data, 0, totalbytesremaining);
        //            totalbytesremaining -= bytes;
        //        }

        //        // Get the ASCII representation of XML payload.
        //        var requestData = Encoding.ASCII.GetString(data, 0, data.Length);

        //        logger.Debug($"Request:: InvokeId {requestInvokeId}{Environment.NewLine}{requestData}");

        //        return (requestData, requestInvokeId);
        //    }
        //    catch (ThreadAbortException ex)
        //    {

        //        /* When user presses 'any key' to stop the application, reader thread is aborted to immediately
        //         * stop the processing. This results in receiveing ThreadAbortException here.
        //         * Just clean the response data varaible and return as application is about to terminate.
        //         */
        //        //Console.WriteLine("Threadabortexception");
        //        return ($"ThreadAbortException occurred.\n{ex.Message}\n{ex.StackTrace}", -1);
        //    }
        //    catch (IOException ex)
        //    {
        //        if (ex.InnerException is ThreadAbortException)
        //        {
        //            return ($"ThreadAbortException occurred.\n{ex.Message}\n{ex.StackTrace}", -1);
        //        }
        //        return ($"EndOfStreamException occurred.\n{ex.Message}\n{ex.StackTrace}", -1);
        //    }
        //    catch (Exception ex)
        //    {
        //        return ($"Exception occurred.\n{ex.Message}\n{ex.StackTrace}", -1);
        //    }
        //}
    }
}
