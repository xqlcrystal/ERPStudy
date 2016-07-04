using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.ServiceModel.MsmqIntegration;

namespace ERPStudy.WCF
{
    class WCFBindings
    {
        public static void ShowBindingInfo()
        {
            IList<Binding> bindings = new List<Binding>();
            bindings.Add(new BasicHttpBinding());
            bindings.Add(new NetNamedPipeBinding());
            bindings.Add(new NetTcpBinding());
            bindings.Add(new WSDualHttpBinding());
            bindings.Add(new WSHttpBinding());
            bindings.Add(new NetMsmqBinding());
            bindings.Add(new MsmqIntegrationBinding());
            bindings.Add(new WSFederationHttpBinding());
            bindings.Add(new NetPeerTcpBinding());

            ShowBindingElement(bindings);

        }

        private static void ShowBindingElement(IList<Binding> bindings)
        {
            foreach (Binding binding in bindings)
            {
                Console.WriteLine("Show binding element for {0}", binding.GetType().Name);
                foreach (BindingElement element in binding.CreateBindingElements())
                {
                    Console.WriteLine("\t{0}", element.GetType().Name);
                }
            }
        }
    }
}
