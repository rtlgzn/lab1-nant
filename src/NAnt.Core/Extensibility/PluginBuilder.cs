// NAnt - A .NET build tool
// Copyright (C) 2001-2008 Gerry Shaw
//
// This program is free software; you can redistribute it and/or modify
// it under the terms of the GNU General Public License as published by
// the Free Software Foundation; either version 2 of the License, or
// (at your option) any later version.
//
// This program is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU General Public License for more details.
//
// You should have received a copy of the GNU General Public License
// along with this program; if not, write to the Free Software
// Foundation, Inc., 59 Temple Place, Suite 330, Boston, MA  02111-1307  USA
//
// Gert Driesen (drieseng@users.sourceforge.net.be)

using System;

namespace NAnt.Core.Extensibility {
    internal class PluginBuilder : ExtensionBuilder {
        internal PluginBuilder(ExtensionAssembly extensionAssembly, Type pluginType) : base (extensionAssembly) {
            _pluginType = pluginType;
        }

        public Type PluginType {
            get { return _pluginType; }
        }

        public IPlugin CreatePlugin() {
            return (IPlugin) Activator.CreateInstance(PluginType);
        }

        private readonly Type _pluginType;
    }
}
