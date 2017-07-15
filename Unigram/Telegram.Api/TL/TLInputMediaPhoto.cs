// <auto-generated/>
using System;

namespace Telegram.Api.TL
{
	public partial class TLInputMediaPhoto : TLInputMediaBase, ITLMessageMediaCaption 
	{
		public TLInputPhotoBase Id { get; set; }
		public String Caption { get; set; }

		public TLInputMediaPhoto() { }
		public TLInputMediaPhoto(TLBinaryReader from)
		{
			Read(from);
		}

		public override TLType TypeId { get { return TLType.InputMediaPhoto; } }

		public override void Read(TLBinaryReader from)
		{
			Id = TLFactory.Read<TLInputPhotoBase>(from);
			Caption = from.ReadString();
		}

		public override void Write(TLBinaryWriter to)
		{
			to.Write(0xE9BFB4F3);
			to.WriteObject(Id);
			to.Write(Caption);
		}
	}
}