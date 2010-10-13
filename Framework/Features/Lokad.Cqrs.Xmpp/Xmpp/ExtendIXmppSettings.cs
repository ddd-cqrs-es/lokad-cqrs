﻿using System.Collections.Generic;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Xml;
using jabber.protocol.client;

namespace Lokad.Cqrs.Xmpp
{

	//public static class Extend

	public static class ExtendIXmppSettings
	{
		public static bool Has(this IXmppSettings settings, XmppOptions options)
		{
			return (settings.Options & options) == options;
		}
	}
}
