﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.269
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace IronFoundry.Nats.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("IronFoundry.Nats.Properties.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Attempting reconnect to server..
        /// </summary>
        internal static string NatsClient_AttemptingReconnect_Message {
            get {
                return ResourceManager.GetString("NatsClient_AttemptingReconnect_Message", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Invalid attempt to reconnect twice..
        /// </summary>
        internal static string NatsClient_AttemptingReconnectTwice_Message {
            get {
                return ResourceManager.GetString("NatsClient_AttemptingReconnectTwice_Message", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Invalid attempt to stop twice..
        /// </summary>
        internal static string NatsClient_AttemptingStopTwice_Message {
            get {
                return ResourceManager.GetString("NatsClient_AttemptingStopTwice_Message", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Can&apos;t change NATS configuration after calling Start().
        /// </summary>
        internal static string NatsClient_CantChangeConfigAfterStart_Message {
            get {
                return ResourceManager.GetString("NatsClient_CantChangeConfigAfterStart_Message", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Connection attempt {0} of {1} failed. Retrying..
        /// </summary>
        internal static string NatsClient_ConnectFailed_Fmt {
            get {
                return ResourceManager.GetString("NatsClient_ConnectFailed_Fmt", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to NATS could not connect to Host: {0}, Port: {1}.
        /// </summary>
        internal static string NatsClient_ConnectionFailed_Fmt {
            get {
                return ResourceManager.GetString("NatsClient_ConnectionFailed_Fmt", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to NATS Connected on Host: {0}, Port: {1}.
        /// </summary>
        internal static string NatsClient_ConnectSuccess_Fmt {
            get {
                return ResourceManager.GetString("NatsClient_ConnectSuccess_Fmt", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Could not reconnect to server..
        /// </summary>
        internal static string NatsClient_CouldNotReconnect_Message {
            get {
                return ResourceManager.GetString("NatsClient_CouldNotReconnect_Message", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to NATS disconnected from server!.
        /// </summary>
        internal static string NatsClient_Disconnected_Message {
            get {
                return ResourceManager.GetString("NatsClient_Disconnected_Message", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to NATS disconnected in Poll().
        /// </summary>
        internal static string NatsClient_DisconnectedInPoll_Message {
            get {
                return ResourceManager.GetString("NatsClient_DisconnectedInPoll_Message", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to NATS disconnected in Write(), message: {0}.
        /// </summary>
        internal static string NatsClient_DisconnectedInWrite_Fmt {
            get {
                return ResourceManager.GetString("NatsClient_DisconnectedInWrite_Fmt", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to NATS callback exception for subscription &apos;{0}&apos;.
        /// </summary>
        internal static string NatsClient_ExceptionInCallbackForSubscription_Fmt {
            get {
                return ResourceManager.GetString("NatsClient_ExceptionInCallbackForSubscription_Fmt", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Exception sending message: {0}.
        /// </summary>
        internal static string NatsClient_ExceptionSendingMessage_Fmt {
            get {
                return ResourceManager.GetString("NatsClient_ExceptionSendingMessage_Fmt", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to NATS Info message: {0}.
        /// </summary>
        internal static string NatsClient_InfoMessage_Fmt {
            get {
                return ResourceManager.GetString("NatsClient_InfoMessage_Fmt", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to NATS Messaging Provider Initialized. Identifier: {0:N}, Server Host: {1}, Server Port: {2}..
        /// </summary>
        internal static string NatsClient_Initialized_Fmt {
            get {
                return ResourceManager.GetString("NatsClient_Initialized_Fmt", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Invalid attempt to publish message of type &apos;{0}&apos; with subject &apos;{1}&apos;.
        /// </summary>
        internal static string NatsClient_InvalidPublishAttempt_Fmt {
            get {
                return ResourceManager.GetString("NatsClient_InvalidPublishAttempt_Fmt", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to NATS Msg Recv: {0}.
        /// </summary>
        internal static string NatsClient_LogReceived_Fmt {
            get {
                return ResourceManager.GetString("NatsClient_LogReceived_Fmt", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to NATS Msg Sent: {0}.
        /// </summary>
        internal static string NatsClient_LogSent_Fmt {
            get {
                return ResourceManager.GetString("NatsClient_LogSent_Fmt", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to NATS Message Acknowledged: {0}.
        /// </summary>
        internal static string NatsClient_MessageAck_Fmt {
            get {
                return ResourceManager.GetString("NatsClient_MessageAck_Fmt", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to NATS ERR: {0}.
        /// </summary>
        internal static string NatsClient_NatsErrorReceived_Fmt {
            get {
                return ResourceManager.GetString("NatsClient_NatsErrorReceived_Fmt", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to NATS INFO: {0}.
        /// </summary>
        internal static string NatsClient_NatsInfoReceived_Fmt {
            get {
                return ResourceManager.GetString("NatsClient_NatsInfoReceived_Fmt", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to NATS UNKNOWN: {0}.
        /// </summary>
        internal static string NatsClient_NatsUnknownReceived_Fmt {
            get {
                return ResourceManager.GetString("NatsClient_NatsUnknownReceived_Fmt", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to NATS Message Subject: {0} not found to be subscribed. Ignoring received message {1}, {2}.
        /// </summary>
        internal static string NatsClient_NonSubscribedSubject_Fmt {
            get {
                return ResourceManager.GetString("NatsClient_NonSubscribedSubject_Fmt", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to NATS Connect message: {0}.
        /// </summary>
        internal static string NatsClient_PublishConnect_Fmt {
            get {
                return ResourceManager.GetString("NatsClient_PublishConnect_Fmt", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to NATS Publishing subject: {0} delay: {1} message: {2}.
        /// </summary>
        internal static string NatsClient_PublishMessage_Fmt {
            get {
                return ResourceManager.GetString("NatsClient_PublishMessage_Fmt", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Attempt to publish receive-only message!.
        /// </summary>
        internal static string NatsClient_PublishReceiveOnlyMessage {
            get {
                return ResourceManager.GetString("NatsClient_PublishReceiveOnlyMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Successfully reconnected to server..
        /// </summary>
        internal static string NatsClient_ReconnectSuccess_Message {
            get {
                return ResourceManager.GetString("NatsClient_ReconnectSuccess_Message", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to NATS Subscribing to subject: {0}, sequence {1}.
        /// </summary>
        internal static string NatsClient_SubscribingToSubject_Fmt {
            get {
                return ResourceManager.GetString("NatsClient_SubscribingToSubject_Fmt", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unknown received message: {0}.
        /// </summary>
        internal static string NatsClient_UnknownReceivedMessage_Fmt {
            get {
                return ResourceManager.GetString("NatsClient_UnknownReceivedMessage_Fmt", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to NATS provider waiting for tasks to complete..
        /// </summary>
        internal static string NatsClient_WaitingForTasks_Message {
            get {
                return ResourceManager.GetString("NatsClient_WaitingForTasks_Message", resourceCulture);
            }
        }
    }
}
