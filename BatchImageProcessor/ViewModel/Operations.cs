﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatchImageProcessor.ViewModel
{
	public class Operations
	{
		public OpType RotationType { get; set; }
		public RotationAmount RotationAmount { get; set; }
		public OpType ResizeType { get; set; }
		public System.Drawing.Size ResizeAmount { get; set; }
		public OpType CropType { get; set; }
		public System.Drawing.Size CropAmount { get; set; }
		public OpType WatermarkType { get; set; }
		public WatermarkSettings WatermarkSettings { get; set; }
	}

	public enum OpType
	{
		Default,
		Custom,
		None
	}

	public enum RotationAmount
	{
		Rot90,
		Rot180,
		Rot270
	}

	public enum WatermarkType
	{
		Image,
		Text
	}

	public enum Alignment
	{
		TopLeft,
		TopCenter,
		TopRight,
		MiddleLeft,
		MiddleCenter,
		MiddleRight,
		BottomLeft,
		BottomCenter,
		BottomRight
	}

	public sealed class WatermarkSettings : IDisposable
	{
		public WatermarkType Type = WatermarkType.Text;
		public string Content = "© " + DateTime.Now.Year + System.Environment.UserName;
		public Alignment Alignment = Alignment.BottomRight;
		public System.Drawing.Font Font = new System.Drawing.Font("Arial", 12f);

		public void Dispose()
		{
			Font.Dispose();
			GC.SuppressFinalize(this);
		}
	}
}