using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Http;
using Nancy.Bootstrapper;

namespace Nancy.AspNetCore.Http.Accessors
{
    internal class NancyAccessors : INancyAccessors
    {
        private object container;
        private IPipelines pipelines;

        public TContainer GetContainer<TContainer>()
        {   
            return (TContainer)this.container;            
        }

        public IPipelines GetPipelines()
        {
            return this.pipelines;
        }
        
        internal NancyAccessors(object container,IPipelines pipelines)
        {
            this.container = container;
            this.pipelines = pipelines;
        }
    }
}
