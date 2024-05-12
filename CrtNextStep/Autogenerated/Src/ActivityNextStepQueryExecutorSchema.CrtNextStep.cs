﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ActivityNextStepQueryExecutorSchema

	/// <exclude/>
	public class ActivityNextStepQueryExecutorSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ActivityNextStepQueryExecutorSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ActivityNextStepQueryExecutorSchema(ActivityNextStepQueryExecutorSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("f9acd7de-eb4a-46d4-956b-6c169318a9de");
			Name = "ActivityNextStepQueryExecutor";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("a39f3d79-3277-4890-a39e-707c83f6a851");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,181,88,91,111,211,72,20,126,14,18,255,97,54,43,129,45,37,174,67,80,104,75,27,212,166,41,202,138,94,182,45,203,3,66,171,169,125,220,204,202,151,116,102,12,100,81,255,251,158,241,140,175,177,75,129,238,91,60,115,206,119,238,151,73,76,35,16,43,234,1,185,2,206,169,72,2,233,204,146,56,96,55,41,167,146,37,177,115,10,95,229,165,132,149,120,250,228,219,211,39,189,84,176,248,134,92,174,133,132,232,117,227,27,57,195,16,60,197,38,156,183,16,3,103,222,6,205,59,22,223,150,135,85,169,81,148,196,221,55,206,31,162,235,154,67,215,185,51,143,37,147,12,68,39,193,49,245,100,194,53,5,210,252,206,225,6,213,39,179,144,10,177,75,14,208,152,207,76,174,115,39,252,153,2,95,207,191,130,151,34,83,198,176,181,181,69,246,68,26,69,148,175,167,230,123,17,173,66,136,32,150,153,7,241,26,128,120,28,130,253,254,162,21,168,191,53,37,65,194,201,243,92,220,115,2,74,239,181,147,11,216,170,72,248,120,4,1,77,67,121,200,98,31,13,178,228,122,5,73,96,181,67,219,3,114,138,33,38,251,164,127,175,45,125,251,19,66,179,88,2,143,105,72,60,101,254,253,214,239,146,118,137,8,243,45,243,76,225,203,99,6,161,143,206,60,231,236,51,149,160,47,87,250,131,112,160,126,18,135,107,242,94,0,199,204,139,117,254,144,191,211,218,247,107,3,9,177,175,81,235,34,144,80,72,158,170,80,42,65,233,117,200,60,35,39,251,125,191,41,86,67,118,234,217,68,229,122,175,215,208,2,221,152,102,25,221,187,187,95,159,19,144,203,164,211,230,44,41,215,151,222,18,34,138,37,147,70,49,121,11,242,2,66,188,244,245,129,133,230,168,108,229,250,80,115,168,72,230,154,125,166,156,128,184,69,141,98,248,82,67,204,76,179,26,154,59,85,138,19,26,211,27,224,3,210,215,167,37,89,63,135,239,161,75,14,252,136,197,23,236,102,41,5,138,9,104,40,96,160,47,103,20,113,22,88,205,121,110,53,113,180,17,162,159,145,223,101,30,235,25,139,188,236,234,253,194,55,188,104,132,115,224,231,102,247,103,249,117,223,118,20,133,230,173,106,79,168,137,165,249,220,111,230,74,155,173,216,142,228,2,115,132,198,30,28,102,142,180,138,130,232,219,90,136,210,228,152,133,88,2,66,105,100,169,239,25,230,167,4,125,250,129,201,229,57,229,200,171,72,44,125,136,205,105,69,57,195,222,116,133,117,232,204,111,83,26,162,99,177,217,85,181,80,246,24,223,245,234,234,59,120,101,219,85,43,203,38,90,88,90,218,38,140,199,208,156,38,117,51,228,6,148,131,76,121,43,148,115,9,138,213,242,42,249,61,109,87,210,196,19,221,19,251,135,107,84,185,194,164,116,81,182,155,16,254,69,195,20,246,222,166,204,159,90,181,88,219,182,173,193,157,15,75,224,96,46,81,164,73,9,242,27,230,114,26,134,228,217,51,115,226,92,64,128,148,24,50,173,198,27,71,231,204,126,75,89,24,232,99,198,133,60,227,166,69,90,246,143,21,107,165,111,100,109,151,197,168,41,147,126,226,221,219,191,149,7,138,49,105,42,119,64,148,11,108,108,237,149,46,244,142,9,185,151,83,158,36,62,132,83,210,194,107,186,191,178,75,195,152,3,204,148,74,245,115,16,104,162,105,0,45,200,198,120,67,91,233,45,200,178,209,110,74,137,134,139,5,196,106,112,233,240,20,29,194,36,150,86,67,51,221,149,173,41,115,13,218,82,134,168,58,131,250,175,31,175,137,181,136,170,20,244,69,242,101,150,164,177,242,211,200,117,203,243,74,203,81,189,166,245,226,138,201,16,58,238,206,121,226,129,16,115,61,232,59,33,46,37,229,242,8,189,136,237,236,140,251,192,15,215,7,194,179,218,137,207,190,224,202,212,1,148,221,93,36,157,250,228,158,157,161,172,155,132,63,106,83,91,136,211,68,158,98,236,7,245,68,114,116,89,63,122,247,220,20,50,40,43,224,255,104,214,184,168,165,89,115,99,98,217,31,232,81,103,87,202,7,119,100,129,201,166,152,52,80,87,198,230,98,138,158,140,106,13,200,187,228,134,121,52,60,91,129,222,169,47,177,202,61,137,249,80,212,210,175,104,127,82,42,87,204,24,213,52,28,4,16,56,230,94,5,59,254,40,216,158,12,131,241,228,122,56,122,57,114,135,238,100,219,27,190,112,189,96,236,94,143,119,198,175,198,125,219,30,252,188,38,152,31,89,114,212,84,49,128,119,149,74,143,40,11,31,209,127,7,177,255,40,14,236,244,28,188,216,30,143,124,240,134,94,224,185,67,63,24,141,134,215,174,27,12,93,119,228,79,92,216,25,111,123,147,95,243,92,174,194,92,185,230,18,231,147,78,197,86,109,48,94,174,247,114,226,14,39,35,247,213,16,92,212,134,78,94,78,134,163,137,191,61,246,232,181,187,179,237,246,205,140,53,94,223,200,91,93,42,101,28,58,138,105,131,175,107,65,129,230,193,143,110,39,248,236,1,92,38,137,149,37,72,198,67,216,38,110,17,103,69,150,168,86,88,140,50,243,82,50,139,10,74,174,238,213,135,235,115,42,151,141,206,90,130,168,126,250,19,64,213,54,92,130,229,251,172,134,105,91,138,244,116,159,90,21,3,156,35,38,86,33,93,87,200,42,3,172,174,233,15,10,40,141,123,128,144,37,21,133,105,40,163,48,200,212,246,25,159,71,43,185,182,170,44,212,247,153,138,13,13,179,44,23,166,166,143,88,22,49,124,172,238,229,155,80,114,253,15,134,113,90,227,246,204,156,90,248,247,155,164,23,201,141,241,86,14,220,108,83,41,209,244,176,50,218,22,105,211,107,42,251,177,13,241,19,170,82,34,25,248,187,82,231,216,236,87,198,210,218,186,85,72,122,160,65,11,127,148,183,200,94,175,185,76,60,8,97,115,3,201,225,102,116,149,23,227,247,115,37,223,114,114,230,69,45,17,170,121,145,83,156,85,178,189,150,55,111,26,185,186,91,230,81,141,55,51,176,198,105,110,123,111,190,111,119,51,183,155,73,157,67,237,62,16,170,3,166,166,240,249,50,145,201,195,194,82,197,196,199,191,250,211,102,17,97,47,237,194,63,161,2,251,235,220,108,55,133,132,133,223,70,80,235,0,85,183,214,175,55,23,226,50,184,23,112,155,50,14,126,227,69,223,83,59,234,253,246,41,138,43,22,193,180,182,213,230,252,7,69,129,45,226,32,65,36,245,119,29,190,48,57,163,33,251,23,172,102,1,14,136,228,105,30,45,51,174,122,250,45,145,141,160,188,214,236,234,203,98,243,201,209,254,180,211,167,245,195,236,236,233,147,255,0,72,107,2,68,241,20,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("f9acd7de-eb4a-46d4-956b-6c169318a9de"));
		}

		#endregion

	}

	#endregion

}

