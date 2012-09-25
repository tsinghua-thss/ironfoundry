﻿namespace IronFoundry.Bosh.Agent.Handlers
{
    using System;
    using IronFoundry.Bosh.Configuration;
    using Newtonsoft.Json.Linq;

    /*
     * agent/lib/agent/message/*
     * methods:
     * get_state
     * prepare_network_change -> return true
     * compile_package
     * drain
     * get_task
     * stop -> is long_running?, Monit.stop_services, returns "stopped"
     * apply (HUGE)
     * start -> Monit.start_services, then returns "started"
     * ping -> returns "pong"
     * migrate_disk
     * list_disk
     * mount_disk
     * unmount_disk
     * noop -> returns "nope"
     */

    public abstract class BaseMessageHandler : IMessageHandler
    {
        private bool disposed = false;
        protected readonly IBoshConfig config;

        public BaseMessageHandler(IBoshConfig config)
        {
            this.config = config;
        }

        public abstract HandlerResponse Handle(JObject parsed);

        public virtual bool IsLongRunning
        {
            get { return false; }
        }

        public virtual void OnPostReply() { }

        public void Dispose()
        {
            if (false == disposed)
            {
                Dispose(true);
                GC.SuppressFinalize(this);
                disposed = true;
            }
        }

        protected virtual void Dispose(bool disposing) { }
    }
}