﻿#region license
// The MIT License (MIT)

// MzLiteModel.cs

// Copyright (c) 2016 Alexander Lüdemann
// alexander.luedemann@outlook.com
// luedeman@rhrk.uni-kl.de

// Computational Systems Biology, Technical University of Kaiserslautern, Germany
 

// Permission is hereby granted, free of charge, to any person obtaining a copy of
// this software and associated documentation files (the "Software"), to deal in
// the Software without restriction, including without limitation the rights to
// use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of
// the Software, and to permit persons to whom the Software is furnished to do so,
// subject to the following conditions:

// The above copyright notice and this permission notice shall be included in all
// copies or substantial portions of the Software.

// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS
// FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR
// COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER
// IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN
// CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
#endregion

using Newtonsoft.Json;

namespace MzLite.Model
{

    /// <summary>
    /// Exposes the root class of the mz data model.
    /// Captures the use of mass spectrometers, sample descriptions, the mz data generated 
    /// and the processing of that data at the level of peak lists.
    /// </summary>
    [JsonObject(MemberSerialization.OptIn)]
    public class MzLiteModel : NamedItem
    {

        private readonly FileDescription fileDescription = new FileDescription();
        private readonly SampleList samples = new SampleList();        
        private readonly SourceFileList sourceFiles = new SourceFileList();
        private readonly DataProcessingList dataProcessings = new DataProcessingList();
        private readonly SoftwareList software = new SoftwareList();
        private readonly InstrumentList instruments = new InstrumentList();
        private readonly RunList runs = new RunList();

        [JsonConstructor]
        public MzLiteModel([JsonProperty("Name")] string name) : base(name) { }

        [JsonProperty(Required = Required.Always, ObjectCreationHandling = ObjectCreationHandling.Reuse)]
        public FileDescription FileDescription { get { return fileDescription; } } 

        [JsonProperty]
        public SampleList Samples { get { return samples; } }        
        
        [JsonProperty]
        public SoftwareList Software { get { return software; } }

        [JsonProperty]
        public DataProcessingList DataProcessings { get { return dataProcessings; } }

        [JsonProperty]
        public InstrumentList Instruments { get { return instruments; } }

        [JsonProperty]
        public RunList Runs { get { return runs; } }

    }
}
