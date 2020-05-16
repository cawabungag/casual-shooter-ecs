﻿using System;
using InstallerGenerator.Enums;

namespace InstallerGenerator.Models {
	[Serializable]
	internal class AttributeChanges {
		public bool Changed = false;
		public ExecutionType Type;
		public ExecutionPriority Priority;
		public int Order;
		public string Name;
	}
}
