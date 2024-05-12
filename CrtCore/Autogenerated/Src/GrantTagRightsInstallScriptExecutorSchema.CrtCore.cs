﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: GrantTagRightsInstallScriptExecutorSchema

	/// <exclude/>
	public class GrantTagRightsInstallScriptExecutorSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public GrantTagRightsInstallScriptExecutorSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public GrantTagRightsInstallScriptExecutorSchema(GrantTagRightsInstallScriptExecutorSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("4447d5de-0bfa-44ec-915d-78722bdea3e0");
			Name = "GrantTagRightsInstallScriptExecutor";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("a6ded360-42cd-4008-9952-fcaf8207688b");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,213,88,93,111,163,56,20,125,206,72,243,31,172,236,11,145,0,241,145,144,48,157,25,9,8,169,34,205,108,171,166,163,125,28,81,226,166,236,18,147,181,77,119,162,170,255,125,141,13,4,28,146,38,51,121,216,173,170,54,6,223,115,125,175,239,57,215,14,138,214,144,108,162,24,130,123,136,113,68,178,71,170,7,25,122,76,86,57,142,104,146,161,247,239,94,222,191,235,229,36,65,43,176,216,18,10,215,87,210,152,205,79,83,24,23,147,137,126,13,17,196,73,188,155,211,132,197,240,208,115,125,234,179,87,236,229,111,24,174,24,16,8,210,136,144,15,224,26,71,136,222,71,171,187,100,245,68,201,28,17,26,165,233,34,198,201,134,134,63,96,156,211,12,115,179,4,81,136,81,148,130,184,176,59,197,12,124,0,243,3,120,189,23,142,185,91,75,86,204,67,148,173,231,22,39,207,17,133,226,253,70,12,0,134,209,50,67,233,22,92,231,201,18,120,105,26,174,55,105,182,133,16,124,2,8,254,195,31,43,125,207,114,61,219,247,70,218,208,55,166,218,52,52,77,205,245,70,166,102,24,35,99,228,4,6,251,153,244,7,87,199,129,127,136,48,191,17,136,91,224,99,203,240,199,99,51,208,194,177,55,214,134,51,155,129,7,51,95,27,89,193,212,50,3,123,108,187,179,163,224,44,89,94,28,67,66,22,241,19,92,71,223,230,203,22,190,57,11,204,208,48,108,109,98,76,108,109,56,156,122,154,239,13,125,109,92,120,157,56,174,51,9,141,211,240,191,127,221,178,207,18,252,104,24,216,129,235,25,154,55,245,61,109,104,217,51,205,117,13,95,115,198,182,239,26,118,104,121,246,241,220,236,224,89,53,109,50,86,186,176,195,139,105,57,35,215,154,105,163,208,101,65,88,254,80,243,109,207,212,76,99,60,178,66,103,58,52,237,240,68,47,183,249,67,154,196,251,46,198,126,232,249,99,223,214,194,137,203,118,122,52,11,53,215,9,28,205,8,28,199,10,156,105,224,155,14,119,193,235,11,162,165,40,177,118,189,221,226,108,3,49,77,160,92,112,197,182,179,98,68,130,108,224,123,222,26,23,51,10,174,246,122,43,72,175,0,97,127,138,209,235,113,103,95,33,125,202,150,135,74,251,57,99,97,115,54,9,42,41,3,32,92,8,18,43,83,191,230,211,242,161,254,248,73,94,154,30,34,146,99,56,245,119,143,148,65,5,213,219,89,234,11,26,97,122,207,252,145,168,156,117,37,230,36,143,64,153,147,223,33,92,50,210,178,228,48,233,9,17,77,232,86,212,235,29,140,51,188,156,194,71,190,76,49,106,120,232,61,50,141,137,226,39,160,60,71,24,36,28,161,154,76,216,24,92,67,42,49,160,122,45,220,237,36,174,137,218,147,144,116,17,7,84,118,17,85,235,47,182,161,241,175,35,156,218,63,199,122,99,241,237,201,114,4,167,46,188,109,112,250,234,27,27,22,100,235,117,210,181,99,175,141,218,219,112,182,128,135,44,75,193,217,155,88,46,186,136,157,192,34,150,146,112,11,62,80,164,74,27,232,247,217,70,49,7,229,186,139,222,148,175,145,210,159,47,251,229,51,125,134,179,181,210,63,234,187,158,251,199,19,196,80,169,70,55,27,136,252,52,139,255,98,230,249,195,159,204,99,173,150,253,218,227,156,132,127,231,81,170,8,207,250,109,132,89,139,101,178,173,236,75,236,160,54,242,80,209,33,114,70,69,204,22,230,45,215,9,250,134,18,122,18,110,163,225,72,128,156,184,16,94,2,81,15,210,140,64,17,124,13,112,131,255,7,169,105,180,204,11,166,167,3,181,149,34,16,145,178,66,175,234,242,197,188,198,120,199,16,149,92,49,110,17,71,105,132,63,22,45,228,115,197,31,12,105,142,81,109,163,243,181,16,165,152,163,179,205,161,219,65,83,221,43,189,254,146,16,250,81,144,235,243,89,162,86,178,172,244,90,240,171,5,85,10,199,91,136,114,106,84,249,208,162,2,75,5,166,10,140,129,122,49,68,83,252,94,16,209,224,136,214,89,136,37,95,84,208,26,252,76,180,221,72,63,19,101,55,82,59,186,215,174,50,18,24,111,22,16,175,70,16,117,112,83,21,7,166,85,23,195,132,95,118,98,7,197,49,135,95,50,84,80,12,113,129,252,5,62,195,84,140,55,25,73,184,166,239,23,103,233,95,22,255,154,186,136,102,39,74,124,79,95,64,122,64,96,84,176,199,253,174,96,7,109,168,110,89,233,192,234,204,142,4,118,83,165,104,7,192,175,35,74,157,59,201,224,174,78,162,108,177,75,175,100,114,91,230,89,54,168,243,223,158,190,167,239,29,161,117,9,122,87,161,117,29,9,228,131,80,243,0,208,72,21,41,207,1,92,167,184,116,130,23,176,87,245,205,11,211,235,190,20,119,130,236,221,85,212,131,247,11,245,192,157,160,225,234,194,135,150,118,118,164,131,74,95,238,101,140,9,123,253,139,40,173,52,74,77,241,174,204,204,33,219,58,115,131,255,92,143,187,88,107,59,218,45,58,170,195,56,32,204,7,245,248,178,24,114,73,254,2,84,163,134,75,156,179,154,196,94,111,32,93,93,161,218,111,161,242,7,155,192,47,200,126,55,73,42,253,122,83,152,201,49,69,174,9,210,97,88,69,246,182,136,239,108,206,17,242,134,167,134,152,159,119,205,231,59,220,186,151,241,75,126,117,249,147,190,99,144,50,93,110,137,180,1,140,236,237,7,130,222,173,239,13,142,44,82,60,109,63,100,207,254,5,121,2,220,180,155,20,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("4447d5de-0bfa-44ec-915d-78722bdea3e0"));
		}

		#endregion

	}

	#endregion

}
