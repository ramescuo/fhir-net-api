﻿using System;
using System.Collections.Generic;
using Hl7.Fhir.Introspection;
using Hl7.Fhir.Validation;
using System.Linq;
using System.Runtime.Serialization;

/*
  Copyright (c) 2011+, HL7, Inc.
  All rights reserved.
  
  Redistribution and use in source and binary forms, with or without modification, 
  are permitted provided that the following conditions are met:
  
   * Redistributions of source code must retain the above copyright notice, this 
     list of conditions and the following disclaimer.
   * Redistributions in binary form must reproduce the above copyright notice, 
     this list of conditions and the following disclaimer in the documentation 
     and/or other materials provided with the distribution.
   * Neither the name of HL7 nor the names of its contributors may be used to 
     endorse or promote products derived from this software without specific 
     prior written permission.
  
  THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS "AS IS" AND 
  ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT LIMITED TO, THE IMPLIED 
  WARRANTIES OF MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE ARE DISCLAIMED. 
  IN NO EVENT SHALL THE COPYRIGHT HOLDER OR CONTRIBUTORS BE LIABLE FOR ANY DIRECT, 
  INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, OR CONSEQUENTIAL DAMAGES (INCLUDING, BUT 
  NOT LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR SERVICES; LOSS OF USE, DATA, OR 
  PROFITS; OR BUSINESS INTERRUPTION) HOWEVER CAUSED AND ON ANY THEORY OF LIABILITY, 
  WHETHER IN CONTRACT, STRICT LIABILITY, OR TORT (INCLUDING NEGLIGENCE OR OTHERWISE) 
  ARISING IN ANY WAY OUT OF THE USE OF THIS SOFTWARE, EVEN IF ADVISED OF THE 
  POSSIBILITY OF SUCH DAMAGE.
  

*/

//
// Generated on Tue, Mar 24, 2015 14:24+0100 for FHIR v0.4.0
//
namespace Hl7.Fhir.Model
{
    /// <summary>
    /// An XML digital Signature
    /// </summary>
    [FhirType("Signature")]
    [DataContract]
    public partial class Signature : Hl7.Fhir.Model.Element, System.ComponentModel.INotifyPropertyChanged
    {
        [NotMapped]
        public override string TypeName { get { return "Signature"; } }
        
        /// <summary>
        /// Indication of the reason the entity signed the object(s)
        /// </summary>
        [FhirElement("type", InSummary=true, Order=30)]
        [Cardinality(Min=1,Max=-1)]
        [DataMember]
        public List<Hl7.Fhir.Model.Coding> Type
        {
            get { if(_Type==null) _Type = new List<Hl7.Fhir.Model.Coding>(); return _Type; }
            set { _Type = value; OnPropertyChanged("Type"); }
        }
        
        private List<Hl7.Fhir.Model.Coding> _Type;
        
        /// <summary>
        /// When the signature was created
        /// </summary>
        [FhirElement("when", InSummary=true, Order=40)]
        [Cardinality(Min=1,Max=1)]
        [DataMember]
        public Hl7.Fhir.Model.Instant WhenElement
        {
            get { return _WhenElement; }
            set { _WhenElement = value; OnPropertyChanged("WhenElement"); }
        }
        
        private Hl7.Fhir.Model.Instant _WhenElement;
        
        /// <summary>
        /// When the signature was created
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMemberAttribute]
        public DateTimeOffset? When
        {
            get { return WhenElement != null ? WhenElement.Value : null; }
            set
            {
                if(value == null)
                  WhenElement = null; 
                else
                  WhenElement = new Hl7.Fhir.Model.Instant(value);
                OnPropertyChanged("When");
            }
        }
        
        /// <summary>
        /// Who signed the signature
        /// </summary>
        [FhirElement("who", InSummary=true, Order=50, Choice=ChoiceType.DatatypeChoice)]
        [AllowedTypes(typeof(Hl7.Fhir.Model.FhirUri),typeof(Hl7.Fhir.Model.ResourceReference))]
        [Cardinality(Min=1,Max=1)]
        [DataMember]
        public Hl7.Fhir.Model.Element Who
        {
            get { return _Who; }
            set { _Who = value; OnPropertyChanged("Who"); }
        }
        
        private Hl7.Fhir.Model.Element _Who;
        
        /// <summary>
        /// The actual XML Dig-Sig
        /// </summary>
        [FhirElement("blob", InSummary=true, Order=60)]
        [Cardinality(Min=1,Max=1)]
        [DataMember]
        public Hl7.Fhir.Model.Base64Binary BlobElement
        {
            get { return _BlobElement; }
            set { _BlobElement = value; OnPropertyChanged("BlobElement"); }
        }
        
        private Hl7.Fhir.Model.Base64Binary _BlobElement;
        
        /// <summary>
        /// The actual XML Dig-Sig
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMemberAttribute]
        public byte[] Blob
        {
            get { return BlobElement != null ? BlobElement.Value : null; }
            set
            {
                if(value == null)
                  BlobElement = null; 
                else
                  BlobElement = new Hl7.Fhir.Model.Base64Binary(value);
                OnPropertyChanged("Blob");
            }
        }
        
        public override IDeepCopyable CopyTo(IDeepCopyable other)
        {
            var dest = other as Signature;
            
            if (dest != null)
            {
                base.CopyTo(dest);
                if(Type != null) dest.Type = new List<Hl7.Fhir.Model.Coding>(Type.DeepCopy());
                if(WhenElement != null) dest.WhenElement = (Hl7.Fhir.Model.Instant)WhenElement.DeepCopy();
                if(Who != null) dest.Who = (Hl7.Fhir.Model.Element)Who.DeepCopy();
                if(BlobElement != null) dest.BlobElement = (Hl7.Fhir.Model.Base64Binary)BlobElement.DeepCopy();
                return dest;
            }
            else
            	throw new ArgumentException("Can only copy to an object of the same type", "other");
        }
        
        public override IDeepCopyable DeepCopy()
        {
            return CopyTo(new Signature());
        }
        
        public override bool Matches(IDeepComparable other)
        {
            var otherT = other as Signature;
            if(otherT == null) return false;
            
            if(!base.Matches(otherT)) return false;
            if( !DeepComparable.Matches(Type, otherT.Type)) return false;
            if( !DeepComparable.Matches(WhenElement, otherT.WhenElement)) return false;
            if( !DeepComparable.Matches(Who, otherT.Who)) return false;
            if( !DeepComparable.Matches(BlobElement, otherT.BlobElement)) return false;
            
            return true;
        }
        
        public override bool IsExactly(IDeepComparable other)
        {
            var otherT = other as Signature;
            if(otherT == null) return false;
            
            if(!base.IsExactly(otherT)) return false;
            if( !DeepComparable.IsExactly(Type, otherT.Type)) return false;
            if( !DeepComparable.IsExactly(WhenElement, otherT.WhenElement)) return false;
            if( !DeepComparable.IsExactly(Who, otherT.Who)) return false;
            if( !DeepComparable.IsExactly(BlobElement, otherT.BlobElement)) return false;
            
            return true;
        }
        
    }
    
}
