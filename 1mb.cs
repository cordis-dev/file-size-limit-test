using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace file-size-limit-test
{
	partial class test
	{
		[Test]
		[ExpectedException( typeof( MessageTypeException ) )]
		public void TestUnpackSByte_ByteArray_Int64MinValueAsInt64_AsIs()
		{
			var result = Unpacking.UnpackSByte( new byte[] { 0xD3, 0x80, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 } );
		}
		
		[Test]
		[ExpectedException( typeof( MessageTypeException ) )]
		public void TestUnpackSByte_Stream_Int64MinValueAsInt64_AsIs()
		{
			using ( var buffer = new MemoryStream( new byte[] { 0xD3, 0x80, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 } ) )
			{
				var result = Unpacking.UnpackSByte( buffer );
			}
		}
		
		[Test]
		[ExpectedException( typeof( MessageTypeException ) )]
		public void TestUnpackSByte_ByteArray_Int32MinValueMinusOneAsInt64_AsIs()
		{
			var result = Unpacking.UnpackSByte( new byte[] { 0xD3, 0xFF, 0xFF, 0xFF, 0xFF, 0x7F, 0xFF, 0xFF, 0xFF } );
		}
		
		[Test]
		[ExpectedException( typeof( MessageTypeException ) )]
		public void TestUnpackSByte_Stream_Int32MinValueMinusOneAsInt64_AsIs()
		{
			using ( var buffer = new MemoryStream( new byte[] { 0xD3, 0xFF, 0xFF, 0xFF, 0xFF, 0x7F, 0xFF, 0xFF, 0xFF } ) )
			{
				var result = Unpacking.UnpackSByte( buffer );
			}
		}
		
		[Test]
		[ExpectedException( typeof( MessageTypeException ) )]
		public void TestUnpackSByte_ByteArray_Int32MinValueAsInt64_AsIs()
		{
			var result = Unpacking.UnpackSByte( new byte[] { 0xD3, 0xFF, 0xFF, 0xFF, 0xFF, 0x80, 0x00, 0x00, 0x00 } );
		}
		
		[Test]
		[ExpectedException( typeof( MessageTypeException ) )]
		public void TestUnpackSByte_Stream_Int32MinValueAsInt64_AsIs()
		{
			using ( var buffer = new MemoryStream( new byte[] { 0xD3, 0xFF, 0xFF, 0xFF, 0xFF, 0x80, 0x00, 0x00, 0x00 } ) )
			{
				var result = Unpacking.UnpackSByte( buffer );
			}
		}
		
		[Test]
		[ExpectedException( typeof( MessageTypeException ) )]
		public void TestUnpackSByte_ByteArray_Int32MinValueAsInt32_AsIs()
		{
			var result = Unpacking.UnpackSByte( new byte[] { 0xD2, 0x80, 0x00, 0x00, 0x00 } );
		}
		
		[Test]
		[ExpectedException( typeof( MessageTypeException ) )]
		public void TestUnpackSByte_Stream_Int32MinValueAsInt32_AsIs()
		{
			using ( var buffer = new MemoryStream( new byte[] { 0xD2, 0x80, 0x00, 0x00, 0x00 } ) )
			{
				var result = Unpacking.UnpackSByte( buffer );
			}
		}
		
		[Test]
		[ExpectedException( typeof( MessageTypeException ) )]
		public void TestUnpackSByte_ByteArray_Int16MinValueMinusOneAsInt64_AsIs()
		{
			var result = Unpacking.UnpackSByte( new byte[] { 0xD3, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0x7F, 0xFF } );
		}
		
		[Test]
		[ExpectedException( typeof( MessageTypeException ) )]
		public void TestUnpackSByte_Stream_Int16MinValueMinusOneAsInt64_AsIs()
		{
			using ( var buffer = new MemoryStream( new byte[] { 0xD3, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0x7F, 0xFF } ) )
			{
				var result = Unpacking.UnpackSByte( buffer );
			}
		}
		
		[Test]
		[ExpectedException( typeof( MessageTypeException ) )]
		public void TestUnpackSByte_ByteArray_Int16MinValueMinusOneAsInt32_AsIs()
		{
			var result = Unpacking.UnpackSByte( new byte[] { 0xD2, 0xFF, 0xFF, 0x7F, 0xFF } );
		}
		
		[Test]
		[ExpectedException( typeof( MessageTypeException ) )]
		public void TestUnpackSByte_Stream_Int16MinValueMinusOneAsInt32_AsIs()
		{
			using ( var buffer = new MemoryStream( new byte[] { 0xD2, 0xFF, 0xFF, 0x7F, 0xFF } ) )
			{
				var result = Unpacking.UnpackSByte( buffer );
			}
		}
		
		[Test]
		[ExpectedException( typeof( MessageTypeException ) )]
		public void TestUnpackSByte_ByteArray_Int16MinValueAsInt64_AsIs()
		{
			var result = Unpacking.UnpackSByte( new byte[] { 0xD3, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0x80, 0x00 } );
		}
		
		[Test]
		[ExpectedException( typeof( MessageTypeException ) )]
		public void TestUnpackSByte_Stream_Int16MinValueAsInt64_AsIs()
		{
			using ( var buffer = new MemoryStream( new byte[] { 0xD3, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0x80, 0x00 } ) )
			{
				var result = Unpacking.UnpackSByte( buffer );
			}
		}
		
		[Test]
		[ExpectedException( typeof( MessageTypeException ) )]
		public void TestUnpackSByte_ByteArray_Int16MinValueAsInt32_AsIs()
		{
			var result = Unpacking.UnpackSByte( new byte[] { 0xD2, 0xFF, 0xFF, 0x80, 0x00 } );
		}
		
		[Test]
		[ExpectedException( typeof( MessageTypeException ) )]
		public void TestUnpackSByte_Stream_Int16MinValueAsInt32_AsIs()
		{
			using ( var buffer = new MemoryStream( new byte[] { 0xD2, 0xFF, 0xFF, 0x80, 0x00 } ) )
			{
				var result = Unpacking.UnpackSByte( buffer );
			}
		}
		
		[Test]
		[ExpectedException( typeof( MessageTypeException ) )]
		public void TestUnpackSByte_ByteArray_Int16MinValueAsInt16_AsIs()
		{
			var result = Unpacking.UnpackSByte( new byte[] { 0xD1, 0x80, 0x00 } );
		}
		
		[Test]
		[ExpectedException( typeof( MessageTypeException ) )]
		public void TestUnpackSByte_Stream_Int16MinValueAsInt16_AsIs()
		{
			using ( var buffer = new MemoryStream( new byte[] { 0xD1, 0x80, 0x00 } ) )
			{
				var result = Unpacking.UnpackSByte( buffer );
			}
		}
		
		[Test]
		[ExpectedException( typeof( MessageTypeException ) )]
		public void TestUnpackSByte_ByteArray_SByteMinValueMinusOneAsInt64_AsIs()
		{
			var result = Unpacking.UnpackSByte( new byte[] { 0xD3, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0x7F } );
		}
		
		[Test]
		[ExpectedException( typeof( MessageTypeException ) )]
		public void TestUnpackSByte_Stream_SByteMinValueMinusOneAsInt64_AsIs()
		{
			using ( var buffer = new MemoryStream( new byte[] { 0xD3, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0x7F } ) )
			{
				var result = Unpacking.UnpackSByte( buffer );
			}
		}
		
		[Test]
		[ExpectedException( typeof( MessageTypeException ) )]
		public void TestUnpackSByte_ByteArray_SByteMinValueMinusOneAsInt32_AsIs()
		{
			var result = Unpacking.UnpackSByte( new byte[] { 0xD2, 0xFF, 0xFF, 0xFF, 0x7F } );
		}
		
		[Test]
		[ExpectedException( typeof( MessageTypeException ) )]
		public void TestUnpackSByte_Stream_SByteMinValueMinusOneAsInt32_AsIs()
		{
			using ( var buffer = new MemoryStream( new byte[] { 0xD2, 0xFF, 0xFF, 0xFF, 0x7F } ) )
			{
				var result = Unpacking.UnpackSByte( buffer );
			}
		}
		
		[Test]
		[ExpectedException( typeof( MessageTypeException ) )]
		public void TestUnpackSByte_ByteArray_SByteMinValueMinusOneAsInt16_AsIs()
		{
			var result = Unpacking.UnpackSByte( new byte[] { 0xD1, 0xFF, 0x7F } );
		}
		
		[Test]
		[ExpectedException( typeof( MessageTypeException ) )]
		public void TestUnpackSByte_Stream_SByteMinValueMinusOneAsInt16_AsIs()
		{
			using ( var buffer = new MemoryStream( new byte[] { 0xD1, 0xFF, 0x7F } ) )
			{
				var result = Unpacking.UnpackSByte( buffer );
			}
		}
		
		[Test]
		public void TestUnpackSByte_ByteArray_SByteMinValueAsInt64_Fail()
		{
			var result = Unpacking.UnpackSByte( new byte[] { 0xD3, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0x80 } );
			Assert.AreEqual( 9, result.ReadCount );
			Assert.AreEqual( -128L, result.Value );
		}
		
		[Test]
		public void TestUnpackSByte_Stream_SByteMinValueAsInt64_Fail()
		{
			using ( var buffer = new MemoryStream( new byte[] { 0xD3, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0x80 } ) )
			{
				var result = Unpacking.UnpackSByte( buffer );
				Assert.AreEqual( 9, buffer.Position );
				Assert.AreEqual( -128L, result );
			}
		}
		
		[Test]
		public void TestUnpackSByte_ByteArray_SByteMinValueAsInt32_Fail()
		{
			var result = Unpacking.UnpackSByte( new byte[] { 0xD2, 0xFF, 0xFF, 0xFF, 0x80 } );
			Assert.AreEqual( 5, result.ReadCount );
			Assert.AreEqual( -128L, result.Value );
		}
		
		[Test]
		public void TestUnpackSByte_Stream_SByteMinValueAsInt32_Fail()
		{
			using ( var buffer = new MemoryStream( new byte[] { 0xD2, 0xFF, 0xFF, 0xFF, 0x80 } ) )
			{
				var result = Unpacking.UnpackSByte( buffer );
				Assert.AreEqual( 5, buffer.Position );
				Assert.AreEqual( -128L, result );
			}
		}
		
		[Test]
		public void TestUnpackSByte_ByteArray_SByteMinValueAsInt16_Fail()
		{
			var result = Unpacking.UnpackSByte( new byte[] { 0xD1, 0xFF, 0x80 } );
			Assert.AreEqual( 3, result.ReadCount );
			Assert.AreEqual( -128L, result.Value );
		}
		
		[Test]
		public void TestUnpackSByte_Stream_SByteMinValueAsInt16_Fail()
		{
			using ( var buffer = new MemoryStream( new byte[] { 0xD1, 0xFF, 0x80 } ) )
			{
				var result = Unpacking.UnpackSByte( buffer );
				Assert.AreEqual( 3, buffer.Position );
				Assert.AreEqual( -128L, result );
			}
		}
		
		[Test]
		public void TestUnpackSByte_ByteArray_SByteMinValueAsInt8_Fail()
		{
			var result = Unpacking.UnpackSByte( new byte[] { 0xD0, 0x80 } );
			Assert.AreEqual( 2, result.ReadCount );
			Assert.AreEqual( -128L, result.Value );
		}
		
		[Test]
		public void TestUnpackSByte_Stream_SByteMinValueAsInt8_Fail()
		{
			using ( var buffer = new MemoryStream( new byte[] { 0xD0, 0x80 } ) )
			{
				var result = Unpacking.UnpackSByte( buffer );
				Assert.AreEqual( 2, buffer.Position );
				Assert.AreEqual( -128L, result );
			}
		}
		
		[Test]
		public void TestUnpackSByte_ByteArray_NegativeFixNumMinValueMinusOneAsInt64_Fail()
		{
			var result = Unpacking.UnpackSByte( new byte[] { 0xD3, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xDF } );
			Assert.AreEqual( 9, result.ReadCount );
			Assert.AreEqual( -33L, result.Value );
		}
		
		[Test]
		public void TestUnpackSByte_Stream_NegativeFixNumMinValueMinusOneAsInt64_Fail()
		{
			using ( var buffer = new MemoryStream( new byte[] { 0xD3, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xDF } ) )
			{
				var result = Unpacking.UnpackSByte( buffer );
				Assert.AreEqual( 9, buffer.Position );
				Assert.AreEqual( -33L, result );
			}
		}
		
		[Test]
		public void TestUnpackSByte_ByteArray_NegativeFixNumMinValueMinusOneAsInt32_Fail()
		{
			var result = Unpacking.UnpackSByte( new byte[] { 0xD2, 0xFF, 0xFF, 0xFF, 0xDF } );
			Assert.AreEqual( 5, result.ReadCount );
			Assert.AreEqual( -33L, result.Value );
		}
		
		[Test]
		public void TestUnpackSByte_Stream_NegativeFixNumMinValueMinusOneAsInt32_Fail()
		{
			using ( var buffer = new MemoryStream( new byte[] { 0xD2, 0xFF, 0xFF, 0xFF, 0xDF } ) )
			{
				var result = Unpacking.UnpackSByte( buffer );
				Assert.AreEqual( 5, buffer.Position );
				Assert.AreEqual( -33L, result );
			}
		}
		
		[Test]
		public void TestUnpackSByte_ByteArray_NegativeFixNumMinValueMinusOneAsInt16_Fail()
		{
			var result = Unpacking.UnpackSByte( new byte[] { 0xD1, 0xFF, 0xDF } );
			Assert.AreEqual( 3, result.ReadCount );
			Assert.AreEqual( -33L, result.Value );
		}
		
		[Test]
		public void TestUnpackSByte_Stream_NegativeFixNumMinValueMinusOneAsInt16_Fail()
		{
			using ( var buffer = new MemoryStream( new byte[] { 0xD1, 0xFF, 0xDF } ) )
			{
				var result = Unpacking.UnpackSByte( buffer );
				Assert.AreEqual( 3, buffer.Position );
				Assert.AreEqual( -33L, result );
			}
		}
		
		[Test]
		public void TestUnpackSByte_ByteArray_NegativeFixNumMinValueMinusOneAsInt8_Fail()
		{
			var result = Unpacking.UnpackSByte( new byte[] { 0xD0, 0xDF } );
			Assert.AreEqual( 2, result.ReadCount );
			Assert.AreEqual( -33L, result.Value );
		}
		
		[Test]
		public void TestUnpackSByte_Stream_NegativeFixNumMinValueMinusOneAsInt8_Fail()
		{
			using ( var buffer = new MemoryStream( new byte[] { 0xD0, 0xDF } ) )
			{
				var result = Unpacking.UnpackSByte( buffer );
				Assert.AreEqual( 2, buffer.Position );
				Assert.AreEqual( -33L, result );
			}
		}
		
		[Test]
		public void TestUnpackSByte_ByteArray_NegativeFixNumMinValueAsInt64_Fail()
		{
			var result = Unpacking.UnpackSByte( new byte[] { 0xD3, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xE0 } );
			Assert.AreEqual( 9, result.ReadCount );
			Assert.AreEqual( -32L, result.Value );
		}
		
		[Test]
		public void TestUnpackSByte_Stream_NegativeFixNumMinValueAsInt64_Fail()
		{
			using ( var buffer = new MemoryStream( new byte[] { 0xD3, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xE0 } ) )
			{
				var result = Unpacking.UnpackSByte( buffer );
				Assert.AreEqual( 9, buffer.Position );
				Assert.AreEqual( -32L, result );
			}
		}
		
		[Test]
		public void TestUnpackSByte_ByteArray_NegativeFixNumMinValueAsInt32_Fail()
		{
			var result = Unpacking.UnpackSByte( new byte[] { 0xD2, 0xFF, 0xFF, 0xFF, 0xE0 } );
			Assert.AreEqual( 5, result.ReadCount );
			Assert.AreEqual( -32L, result.Value );
		}
		
		[Test]
		public void TestUnpackSByte_Stream_NegativeFixNumMinValueAsInt32_Fail()
		{
			using ( var buffer = new MemoryStream( new byte[] { 0xD2, 0xFF, 0xFF, 0xFF, 0xE0 } ) )
			{
				var result = Unpacking.UnpackSByte( buffer );
				Assert.AreEqual( 5, buffer.Position );
				Assert.AreEqual( -32L, result );
			}
		}
		
		[Test]
		public void TestUnpackSByte_ByteArray_NegativeFixNumMinValueAsInt16_Fail()
		{
			var result = Unpacking.UnpackSByte( new byte[] { 0xD1, 0xFF, 0xE0 } );
			Assert.AreEqual( 3, result.ReadCount );
			Assert.AreEqual( -32L, result.Value );
		}
		
		[Test]
		public void TestUnpackSByte_Stream_NegativeFixNumMinValueAsInt16_Fail()
		{
			using ( var buffer = new MemoryStream( new byte[] { 0xD1, 0xFF, 0xE0 } ) )
			{
				var result = Unpacking.UnpackSByte( buffer );
				Assert.AreEqual( 3, buffer.Position );
				Assert.AreEqual( -32L, result );
			}
		}
		
		[Test]
		public void TestUnpackSByte_ByteArray_NegativeFixNumMinValueAsInt8_Fail()
		{
			var result = Unpacking.UnpackSByte( new byte[] { 0xD0, 0xE0 } );
			Assert.AreEqual( 2, result.ReadCount );
			Assert.AreEqual( -32L, result.Value );
		}
		
		[Test]
		public void TestUnpackSByte_Stream_NegativeFixNumMinValueAsInt8_Fail()
		{
			using ( var buffer = new MemoryStream( new byte[] { 0xD0, 0xE0 } ) )
			{
				var result = Unpacking.UnpackSByte( buffer );
				Assert.AreEqual( 2, buffer.Position );
				Assert.AreEqual( -32L, result );
			}
		}
		
		[Test]
		public void TestUnpackSByte_ByteArray_NegativeFixNumMinValueAsNegativeFixNumMinus32_Fail()
		{
			var result = Unpacking.UnpackSByte( new byte[] { 0xE0 } );
			Assert.AreEqual( 1, result.ReadCount );
			Assert.AreEqual( -32L, result.Value );
		}
		
		[Test]
		public void TestUnpackSByte_Stream_NegativeFixNumMinValueAsNegativeFixNumMinus32_Fail()
		{
			using ( var buffer = new MemoryStream( new byte[] { 0xE0 } ) )
			{
				var result = Unpacking.UnpackSByte( buffer );
				Assert.AreEqual( 1, buffer.Position );
				Assert.AreEqual( -32L, result );
			}
		}
		
		[Test]
		public void TestUnpackSByte_ByteArray_MinusOneAsInt64_Fail()
		{
			var result = Unpacking.UnpackSByte( new byte[] { 0xD3, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF } );
			Assert.AreEqual( 9, result.ReadCount );
			Assert.AreEqual( -1L, result.Value );
		}
		
		[Test]
		public void TestUnpackSByte_Stream_MinusOneAsInt64_Fail()
		{
			using ( var buffer = new MemoryStream( new byte[] { 0xD3, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF } ) )
			{
				var result = Unpacking.UnpackSByte( buffer );
				Assert.AreEqual( 9, buffer.Position );
				Assert.AreEqual( -1L, result );
			}
		}
		
		[Test]
		public void TestUnpackSByte_ByteArray_MinusOneAsInt32_Fail()
		{
			var result = Unpacking.UnpackSByte( new byte[] { 0xD2, 0xFF, 0xFF, 0xFF, 0xFF } );
			Assert.AreEqual( 5, result.ReadCount );
			Assert.AreEqual( -1L, result.Value );
		}
		
		[Test]
		public void TestUnpackSByte_Stream_MinusOneAsInt32_Fail()
		{
			using ( var buffer = new MemoryStream( new byte[] { 0xD2, 0xFF, 0xFF, 0xFF, 0xFF } ) )
			{
				var result = Unpacking.UnpackSByte( buffer );
				Assert.AreEqual( 5, buffer.Position );
				Assert.AreEqual( -1L, result );
			}
		}
		
		[Test]
		public void TestUnpackSByte_ByteArray_MinusOneAsInt16_Fail()
		{
			var result = Unpacking.UnpackSByte( new byte[] { 0xD1, 0xFF, 0xFF } );
			Assert.AreEqual( 3, result.ReadCount );
			Assert.AreEqual( -1L, result.Value );
		}
		
		[Test]
		public void TestUnpackSByte_Stream_MinusOneAsInt16_Fail()
		{
			using ( var buffer = new MemoryStream( new byte[] { 0xD1, 0xFF, 0xFF } ) )
			{
				var result = Unpacking.UnpackSByte( buffer );
				Assert.AreEqual( 3, buffer.Position );
				Assert.AreEqual( -1L, result );
			}
		}
		
		[Test]
		public void TestUnpackSByte_ByteArray_MinusOneAsInt8_Fail()
		{
			var result = Unpacking.UnpackSByte( new byte[] { 0xD0, 0xFF } );
			Assert.AreEqual( 2, result.ReadCount );
			Assert.AreEqual( -1L, result.Value );
		}
		
		[Test]
		public void TestUnpackSByte_Stream_MinusOneAsInt8_Fail()
		{
			using ( var buffer = new MemoryStream( new byte[] { 0xD0, 0xFF } ) )
			{
				var result = Unpacking.UnpackSByte( buffer );
				Assert.AreEqual( 2, buffer.Position );
				Assert.AreEqual( -1L, result );
			}
		}
		
		[Test]
		public void TestUnpackSByte_ByteArray_MinusOneAsNegativeFixNumMinus1_Fail()
		{
			var result = Unpacking.UnpackSByte( new byte[] { 0xFF } );
			Assert.AreEqual( 1, result.ReadCount );
			Assert.AreEqual( -1L, result.Value );
		}
		
		[Test]
		public void TestUnpackSByte_Stream_MinusOneAsNegativeFixNumMinus1_Fail()
		{
			using ( var buffer = new MemoryStream( new byte[] { 0xFF } ) )
			{
				var result = Unpacking.UnpackSByte( buffer );
				Assert.AreEqual( 1, buffer.Position );
				Assert.AreEqual( -1L, result );
			}
		}
		
		[Test]
		public void TestUnpackSByte_ByteArray_ZeroAsInt64_Fail()
		{
			var result = Unpacking.UnpackSByte( new byte[] { 0xD3, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 } );
			Assert.AreEqual( 9, result.ReadCount );
			Assert.AreEqual( 0L, result.Value );
		}
		
		[Test]
		public void TestUnpackSByte_Stream_ZeroAsInt64_Fail()
		{
			using ( var buffer = new MemoryStream( new byte[] { 0xD3, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 } ) )
			{
				var result = Unpacking.UnpackSByte( buffer );
				Assert.AreEqual( 9, buffer.Position );
				Assert.AreEqual( 0L, result );
			}
		}
		
		[Test]
		public void TestUnpackSByte_ByteArray_ZeroAsUInt64_Fail()
		{
			var result = Unpacking.UnpackSByte( new byte[] { 0xCF, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 } );
			Assert.AreEqual( 9, result.ReadCount );
			Assert.AreEqual( 0L, result.Value );
		}
		
		[Test]
		public void TestUnpackSByte_Stream_ZeroAsUInt64_Fail()
		{
			using ( var buffer = new MemoryStream( new byte[] { 0xCF, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 } ) )
			{
				var result = Unpacking.UnpackSByte( buffer );
				Assert.AreEqual( 9, buffer.Position );
				Assert.AreEqual( 0L, result );
			}
		}
		
		[Test]
		public void TestUnpackSByte_ByteArray_ZeroAsInt32_Fail()
		{
			var result = Unpacking.UnpackSByte( new byte[] { 0xD2, 0x00, 0x00, 0x00, 0x00 } );
			Assert.AreEqual( 5, result.ReadCount );
			Assert.AreEqual( 0L, result.Value );
		}
		
		[Test]
		public void TestUnpackSByte_Stream_ZeroAsInt32_Fail()
		{
			using ( var buffer = new MemoryStream( new byte[] { 0xD2, 0x00, 0x00, 0x00, 0x00 } ) )
			{
				var result = Unpacking.UnpackSByte( buffer );
				Assert.AreEqual( 5, buffer.Position );
				Assert.AreEqual( 0L, result );
			}
		}
		
		[Test]
		public void TestUnpackSByte_ByteArray_ZeroAsUInt32_Fail()
		{
			var result = Unpacking.UnpackSByte( new byte[] { 0xCE, 0x00, 0x00, 0x00, 0x00 } );
			Assert.AreEqual( 5, result.ReadCount );
			Assert.AreEqual( 0L, result.Value );
		}
		
		[Test]
		public void TestUnpackSByte_Stream_ZeroAsUInt32_Fail()
		{
			using ( var buffer = new MemoryStream( new byte[] { 0xCE, 0x00, 0x00, 0x00, 0x00 } ) )
			{
				var result = Unpacking.UnpackSByte( buffer );
				Assert.AreEqual( 5, buffer.Position );
				Assert.AreEqual( 0L, result );
			}
		}
		
		[Test]
		public void TestUnpackSByte_ByteArray_ZeroAsInt16_Fail()
		{
			var result = Unpacking.UnpackSByte( new byte[] { 0xD1, 0x00, 0x00 } );
			Assert.AreEqual( 3, result.ReadCount );
			Assert.AreEqual( 0L, result.Value );
		}
		
		[Test]
		public void TestUnpackSByte_Stream_ZeroAsInt16_Fail()
		{
			using ( var buffer = new MemoryStream( new byte[] { 0xD1, 0x00, 0x00 } ) )
			{
				var result = Unpacking.UnpackSByte( buffer );
				Assert.AreEqual( 3, buffer.Position );
				Assert.AreEqual( 0L, result );
			}
		}
		
		[Test]
		public void TestUnpackSByte_ByteArray_ZeroAsUInt16_Fail()
		{
			var result = Unpacking.UnpackSByte( new byte[] { 0xCD, 0x00, 0x00 } );
			Assert.AreEqual( 3, result.ReadCount );
			Assert.AreEqual( 0L, result.Value );
		}
		
		[Test]
		public void TestUnpackSByte_Stream_ZeroAsUInt16_Fail()
		{
			using ( var buffer = new MemoryStream( new byte[] { 0xCD, 0x00, 0x00 } ) )
			{
				var result = Unpacking.UnpackSByte( buffer );
				Assert.AreEqual( 3, buffer.Position );
				Assert.AreEqual( 0L, result );
			}
		}
		
		[Test]
		public void TestUnpackSByte_ByteArray_ZeroAsInt8_Fail()
		{
			var result = Unpacking.UnpackSByte( new byte[] { 0xD0, 0x00 } );
			Assert.AreEqual( 2, result.ReadCount );
			Assert.AreEqual( 0L, result.Value );
		}
		
		[Test]
		public void TestUnpackSByte_Stream_ZeroAsInt8_Fail()
		{
			using ( var buffer = new MemoryStream( new byte[] { 0xD0, 0x00 } ) )
			{
				var result = Unpacking.UnpackSByte( buffer );
				Assert.AreEqual( 2, buffer.Position );
				Assert.AreEqual( 0L, result );
			}
		}
		
		[Test]
		public void TestUnpackSByte_ByteArray_ZeroAsUInt8_Fail()
		{
			var result = Unpacking.UnpackSByte( new byte[] { 0xCC, 0x00 } );
			Assert.AreEqual( 2, result.ReadCount );
			Assert.AreEqual( 0L, result.Value );
		}
		
		[Test]
		public void TestUnpackSByte_Stream_ZeroAsUInt8_Fail()
		{
			using ( var buffer = new MemoryStream( new byte[] { 0xCC, 0x00 } ) )
			{
				var result = Unpacking.UnpackSByte( buffer );
				Assert.AreEqual( 2, buffer.Position );
				Assert.AreEqual( 0L, result );
			}
		}
		
		[Test]
		public void TestUnpackSByte_ByteArray_ZeroAsPositiveFixNum0_Fail()
		{
			var result = Unpacking.UnpackSByte( new byte[] { 0x00 } );
			Assert.AreEqual( 1, result.ReadCount );
			Assert.AreEqual( 0L, result.Value );
		}
		
		[Test]
		public void TestUnpackSByte_Stream_ZeroAsPositiveFixNum0_Fail()
		{
			using ( var buffer = new MemoryStream( new byte[] { 0x00 } ) )
			{
				var result = Unpacking.UnpackSByte( buffer );
				Assert.AreEqual( 1, buffer.Position );
				Assert.AreEqual( 0L, result );
			}
		}
		
		[Test]
		public void TestUnpackSByte_ByteArray_PlusOneAsInt64_Fail()
		{
			var result = Unpacking.UnpackSByte( new byte[] { 0xD3, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x01 } );
			Assert.AreEqual( 9, result.ReadCount );
			Assert.AreEqual( 1L, result.Value );
		}
		
		[Test]
		public void TestUnpackSByte_Stream_PlusOneAsInt64_Fail()
		{
			using ( var buffer = new MemoryStream( new byte[] { 0xD3, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x01 } ) )
			{
				var result = Unpacking.UnpackSByte( buffer );
				Assert.AreEqual( 9, buffer.Position );
				Assert.AreEqual( 1L, result );
			}
		}
		
		[Test]
		public void TestUnpackSByte_ByteArray_PlusOneAsUInt64_Fail()
		{
			var result = Unpacking.UnpackSByte( new byte[] { 0xCF, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x01 } );
			Assert.AreEqual( 9, result.ReadCount );
			Assert.AreEqual( 1L, result.Value );
		}
		
		[Test]
		public void TestUnpackSByte_Stream_PlusOneAsUInt64_Fail()
		{
			using ( var buffer = new MemoryStream( new byte[] { 0xCF, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x01 } ) )
			{
				var result = Unpacking.UnpackSByte( buffer );
				Assert.AreEqual( 9, buffer.Position );
				Assert.AreEqual( 1L, result );
			}
		}
		
		[Test]
		public void TestUnpackSByte_ByteArray_PlusOneAsInt32_Fail()
		{
			var result = Unpacking.UnpackSByte( new byte[] { 0xD2, 0x00, 0x00, 0x00, 0x01 } );
			Assert.AreEqual( 5, result.ReadCount );
			Assert.AreEqual( 1L, result.Value );
		}
		
		[Test]
		public void TestUnpackSByte_Stream_PlusOneAsInt32_Fail()
		{
			using ( var buffer = new MemoryStream( new byte[] { 0xD2, 0x00, 0x00, 0x00, 0x01 } ) )
			{
				var result = Unpacking.UnpackSByte( buffer );
				Assert.AreEqual( 5, buffer.Position );
				Assert.AreEqual( 1L, result );
			}
		}
		
		[Test]
		public void TestUnpackSByte_ByteArray_PlusOneAsUInt32_Fail()
		{
			var result = Unpacking.UnpackSByte( new byte[] { 0xCE, 0x00, 0x00, 0x00, 0x01 } );
			Assert.AreEqual( 5, result.ReadCount );
			Assert.AreEqual( 1L, result.Value );
		}
		
		[Test]
		public void TestUnpackSByte_Stream_PlusOneAsUInt32_Fail()
		{
			using ( var buffer = new MemoryStream( new byte[] { 0xCE, 0x00, 0x00, 0x00, 0x01 } ) )
			{
				var result = Unpacking.UnpackSByte( buffer );
				Assert.AreEqual( 5, buffer.Position );
				Assert.AreEqual( 1L, result );
			}
		}
		
		[Test]
		public void TestUnpackSByte_ByteArray_PlusOneAsInt16_Fail()
		{
			var result = Unpacking.UnpackSByte( new byte[] { 0xD1, 0x00, 0x01 } );
			Assert.AreEqual( 3, result.ReadCount );
			Assert.AreEqual( 1L, result.Value );
		}
		
		[Test]
		public void TestUnpackSByte_Stream_PlusOneAsInt16_Fail()
		{
			using ( var buffer = new MemoryStream( new byte[] { 0xD1, 0x00, 0x01 } ) )
			{
				var result = Unpacking.UnpackSByte( buffer );
				Assert.AreEqual( 3, buffer.Position );
				Assert.AreEqual( 1L, result );
			}
		}
		
		[Test]
		public void TestUnpackSByte_ByteArray_PlusOneAsUInt16_Fail()
		{
			var result = Unpacking.UnpackSByte( new byte[] { 0xCD, 0x00, 0x01 } );
			Assert.AreEqual( 3, result.ReadCount );
			Assert.AreEqual( 1L, result.Value );
		}
		
		[Test]
		public void TestUnpackSByte_Stream_PlusOneAsUInt16_Fail()
		{
			using ( var buffer = new MemoryStream( new byte[] { 0xCD, 0x00, 0x01 } ) )
			{
				var result = Unpacking.UnpackSByte( buffer );
				Assert.AreEqual( 3, buffer.Position );
				Assert.AreEqual( 1L, result );
			}
		}
		
		[Test]
		public void TestUnpackSByte_ByteArray_PlusOneAsInt8_Fail()
		{
			var result = Unpacking.UnpackSByte( new byte[] { 0xD0, 0x01 } );
			Assert.AreEqual( 2, result.ReadCount );
			Assert.AreEqual( 1L, result.Value );
		}
		
		[Test]
		public void TestUnpackSByte_Stream_PlusOneAsInt8_Fail()
		{
			using ( var buffer = new MemoryStream( new byte[] { 0xD0, 0x01 } ) )
			{
				var result = Unpacking.UnpackSByte( buffer );
				Assert.AreEqual( 2, buffer.Position );
				Assert.AreEqual( 1L, result );
			}
		}
		
		[Test]
		public void TestUnpackSByte_ByteArray_PlusOneAsUInt8_Fail()
		{
			var result = Unpacking.UnpackSByte( new byte[] { 0xCC, 0x01 } );
			Assert.AreEqual( 2, result.ReadCount );
			Assert.AreEqual( 1L, result.Value );
		}
		
		[Test]
		public void TestUnpackSByte_Stream_PlusOneAsUInt8_Fail()
		{
			using ( var buffer = new MemoryStream( new byte[] { 0xCC, 0x01 } ) )
			{
				var result = Unpacking.UnpackSByte( buffer );
				Assert.AreEqual( 2, buffer.Position );
				Assert.AreEqual( 1L, result );
			}
		}
		
		[Test]
		public void TestUnpackSByte_ByteArray_PlusOneAsPositiveFixNum1_Fail()
		{
			var result = Unpacking.UnpackSByte( new byte[] { 0x01 } );
			Assert.AreEqual( 1, result.ReadCount );
			Assert.AreEqual( 1L, result.Value );
		}
		
		[Test]
		public void TestUnpackSByte_Stream_PlusOneAsPositiveFixNum1_Fail()
		{
			using ( var buffer = new MemoryStream( new byte[] { 0x01 } ) )
			{
				var result = Unpacking.UnpackSByte( buffer );
				Assert.AreEqual( 1, buffer.Position );
				Assert.AreEqual( 1L, result );
			}
		}
		
		[Test]
		public void TestUnpackSByte_ByteArray_PositiveFixNumMaxValueAsInt64_Fail()
		{
			var result = Unpacking.UnpackSByte( new byte[] { 0xD3, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x7F } );
			Assert.AreEqual( 9, result.ReadCount );
			Assert.AreEqual( 127L, result.Value );
		}
		
		[Test]
		public void TestUnpackSByte_Stream_PositiveFixNumMaxValueAsInt64_Fail()
		{
			using ( var buffer = new MemoryStream( new byte[] { 0xD3, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x7F } ) )
			{
				var result = Unpacking.UnpackSByte( buffer );
				Assert.AreEqual( 9, buffer.Position );
				Assert.AreEqual( 127L, result );
			}
		}
		
		[Test]
		public void TestUnpackSByte_ByteArray_PositiveFixNumMaxValueAsUInt64_Fail()
		{
			var result = Unpacking.UnpackSByte( new byte[] { 0xCF, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x7F } );
			Assert.AreEqual( 9, result.ReadCount );
			Assert.AreEqual( 127L, result.Value );
		}
		
		[Test]
		public void TestUnpackSByte_Stream_PositiveFixNumMaxValueAsUInt64_Fail()
		{
			using ( var buffer = new MemoryStream( new byte[] { 0xCF, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x7F } ) )
			{
				var result = Unpacking.UnpackSByte( buffer );
				Assert.AreEqual( 9, buffer.Position );
				Assert.AreEqual( 127L, result );
			}
		}
		
		[Test]
		public void TestUnpackSByte_ByteArray_PositiveFixNumMaxValueAsInt32_Fail()
		{
			var result = Unpacking.UnpackSByte( new byte[] { 0xD2, 0x00, 0x00, 0x00, 0x7F } );
			Assert.AreEqual( 5, result.ReadCount );
			Assert.AreEqual( 127L, result.Value );
		}
		
		[Test]
		public void TestUnpackSByte_Stream_PositiveFixNumMaxValueAsInt32_Fail()
		{
			using ( var buffer = new MemoryStream( new byte[] { 0xD2, 0x00, 0x00, 0x00, 0x7F } ) )
			{
				var result = Unpacking.UnpackSByte( buffer );
				Assert.AreEqual( 5, buffer.Position );
				Assert.AreEqual( 127L, result );
			}
		}
		
		[Test]
		public void TestUnpackSByte_ByteArray_PositiveFixNumMaxValueAsUInt32_Fail()
		{
			var result = Unpacking.UnpackSByte( new byte[] { 0xCE, 0x00, 0x00, 0x00, 0x7F } );
			Assert.AreEqual( 5, result.ReadCount );
			Assert.AreEqual( 127L, result.Value );
		}
		
		[Test]
		public void TestUnpackSByte_Stream_PositiveFixNumMaxValueAsUInt32_Fail()
		{
			using ( var buffer = new MemoryStream( new byte[] { 0xCE, 0x00, 0x00, 0x00, 0x7F } ) )
			{
				var result = Unpacking.UnpackSByte( buffer );
				Assert.AreEqual( 5, buffer.Position );
				Assert.AreEqual( 127L, result );
			}
		}
		
		[Test]
		public void TestUnpackSByte_ByteArray_PositiveFixNumMaxValueAsInt16_Fail()
		{
			var result = Unpacking.UnpackSByte( new byte[] { 0xD1, 0x00, 0x7F } );
			Assert.AreEqual( 3, result.ReadCount );
			Assert.AreEqual( 127L, result.Value );
		}
		
		[Test]
		public void TestUnpackSByte_Stream_PositiveFixNumMaxValueAsInt16_Fail()
		{
			using ( var buffer = new MemoryStream( new byte[] { 0xD1, 0x00, 0x7F } ) )
			{
				var result = Unpacking.UnpackSByte( buffer );
				Assert.AreEqual( 3, buffer.Position );
				Assert.AreEqual( 127L, result );
			}
		}
		
		[Test]
		public void TestUnpackSByte_ByteArray_PositiveFixNumMaxValueAsUInt16_Fail()
		{
			var result = Unpacking.UnpackSByte( new byte[] { 0xCD, 0x00, 0x7F } );
			Assert.AreEqual( 3, result.ReadCount );
			Assert.AreEqual( 127L, result.Value );
		}
		
		[Test]
		public void TestUnpackSByte_Stream_PositiveFixNumMaxValueAsUInt16_Fail()
		{
			using ( var buffer = new MemoryStream( new byte[] { 0xCD, 0x00, 0x7F } ) )
			{
				var result = Unpacking.UnpackSByte( buffer );
				Assert.AreEqual( 3, buffer.Position );
				Assert.AreEqual( 127L, result );
			}
		}
		
		[Test]
		public void TestUnpackSByte_ByteArray_PositiveFixNumMaxValueAsInt8_Fail()
		{
			var result = Unpacking.UnpackSByte( new byte[] { 0xD0, 0x7F } );
			Assert.AreEqual( 2, result.ReadCount );
			Assert.AreEqual( 127L, result.Value );
		}
		
		[Test]
		public void TestUnpackSByte_Stream_PositiveFixNumMaxValueAsInt8_Fail()
		{
			using ( var buffer = new MemoryStream( new byte[] { 0xD0, 0x7F } ) )
			{
				var result = Unpacking.UnpackSByte( buffer );
				Assert.AreEqual( 2, buffer.Position );
				Assert.AreEqual( 127L, result );
			}
		}
		
		[Test]
		public void TestUnpackSByte_ByteArray_PositiveFixNumMaxValueAsUInt8_Fail()
		{
			var result = Unpacking.UnpackSByte( new byte[] { 0xCC, 0x7F } );
			Assert.AreEqual( 2, result.ReadCount );
			Assert.AreEqual( 127L, result.Value );
		}
		
		[Test]
		public void TestUnpackSByte_Stream_PositiveFixNumMaxValueAsUInt8_Fail()
		{
			using ( var buffer = new MemoryStream( new byte[] { 0xCC, 0x7F } ) )
			{
				var result = Unpacking.UnpackSByte( buffer );
				Assert.AreEqual( 2, buffer.Position );
				Assert.AreEqual( 127L, result );
			}
		}
		
		[Test]
		public void TestUnpackSByte_ByteArray_PositiveFixNumMaxValueAsPositiveFixNum127_Fail()
		{
			var result = Unpacking.UnpackSByte( new byte[] { 0x7F } );
			Assert.AreEqual( 1, result.ReadCount );
			Assert.AreEqual( 127L, result.Value );
		}
		
		[Test]
		public void TestUnpackSByte_Stream_PositiveFixNumMaxValueAsPositiveFixNum127_Fail()
		{
			using ( var buffer = new MemoryStream( new byte[] { 0x7F } ) )
			{
				var result = Unpacking.UnpackSByte( buffer );
				Assert.AreEqual( 1, buffer.Position );
				Assert.AreEqual( 127L, result );
			}
		}
		
		[Test]
		[ExpectedException( typeof( MessageTypeException ) )]
		public void TestUnpackSByte_ByteArray_PositiveFixNumMaxValuePlusOneAsInt64_AsIs()
		{
			var result = Unpacking.UnpackSByte( new byte[] { 0xD3, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x80 } );
		}
		
		[Test]
		[ExpectedException( typeof( MessageTypeException ) )]
		public void TestUnpackSByte_Stream_PositiveFixNumMaxValuePlusOneAsInt64_AsIs()
		{
			using ( var buffer = new MemoryStream( new byte[] { 0xD3, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x80 } ) )
			{
				var result = Unpacking.UnpackSByte( buffer );
			}
		}
		
		[Test]
		[ExpectedException( typeof( MessageTypeException ) )]
		public void TestUnpackSByte_ByteArray_PositiveFixNumMaxValuePlusOneAsUInt64_AsIs()
		{
			var result = Unpacking.UnpackSByte( new byte[] { 0xCF, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x80 } );
		}
		
		[Test]
		[ExpectedException( typeof( MessageTypeException ) )]
		public void TestUnpackSByte_Stream_PositiveFixNumMaxValuePlusOneAsUInt64_AsIs()
		{
			using ( var buffer = new MemoryStream( new byte[] { 0xCF, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x80 } ) )
			{
				var result = Unpacking.UnpackSByte( buffer );
			}
		}
		
		[Test]
		[ExpectedException( typeof( MessageTypeException ) )]
		public void TestUnpackSByte_ByteArray_PositiveFixNumMaxValuePlusOneAsInt32_AsIs()
		{
			var result = Unpacking.UnpackSByte( new byte[] { 0xD2, 0x00, 0x00, 0x00, 0x80 } );
		}
		
		[Test]
		[ExpectedException( typeof( MessageTypeException ) )]
		public void TestUnpackSByte_Stream_PositiveFixNumMaxValuePlusOneAsInt32_AsIs()
		{
			using ( var buffer = new MemoryStream( new byte[] { 0xD2, 0x00, 0x00, 0x00, 0x80 } ) )
			{
				var result = Unpacking.UnpackSByte( buffer );
			}
		}
		
		[Test]
		[ExpectedException( typeof( MessageTypeException ) )]
		public void TestUnpackSByte_ByteArray_PositiveFixNumMaxValuePlusOneAsUInt32_AsIs()
		{
			var result = Unpacking.UnpackSByte( new byte[] { 0xCE, 0x00, 0x00, 0x00, 0x80 } );
		}
		
		[Test]
		[ExpectedException( typeof( MessageTypeException ) )]
		public void TestUnpackSByte_Stream_PositiveFixNumMaxValuePlusOneAsUInt32_AsIs()
		{
			using ( var buffer = new MemoryStream( new byte[] { 0xCE, 0x00, 0x00, 0x00, 0x80 } ) )
			{
				var result = Unpacking.UnpackSByte( buffer );
			}
		}
		
		[Test]
		[ExpectedException( typeof( MessageTypeException ) )]
		public void TestUnpackSByte_ByteArray_PositiveFixNumMaxValuePlusOneAsInt16_AsIs()
		{
			var result = Unpacking.UnpackSByte( new byte[] { 0xD1, 0x00, 0x80 } );
		}
		
		[Test]
		[ExpectedException( typeof( MessageTypeException ) )]
		public void TestUnpackSByte_Stream_PositiveFixNumMaxValuePlusOneAsInt16_AsIs()
		{
			using ( var buffer = new MemoryStream( new byte[] { 0xD1, 0x00, 0x80 } ) )
			{
				var result = Unpacking.UnpackSByte( buffer );
			}
		}
		
		[Test]
		[ExpectedException( typeof( MessageTypeException ) )]
		public void TestUnpackSByte_ByteArray_PositiveFixNumMaxValuePlusOneAsUInt16_AsIs()
		{
			var result = Unpacking.UnpackSByte( new byte[] { 0xCD, 0x00, 0x80 } );
		}
		
		[Test]
		[ExpectedException( typeof( MessageTypeException ) )]
		public void TestUnpackSByte_Stream_PositiveFixNumMaxValuePlusOneAsUInt16_AsIs()
		{
			using ( var buffer = new MemoryStream( new byte[] { 0xCD, 0x00, 0x80 } ) )
			{
				var result = Unpacking.UnpackSByte( buffer );
			}
		}
		
		[Test]
		[ExpectedException( typeof( MessageTypeException ) )]
		public void TestUnpackSByte_ByteArray_PositiveFixNumMaxValuePlusOneAsUInt8_AsIs()
		{
			var result = Unpacking.UnpackSByte( new byte[] { 0xCC, 0x80 } );
		}
		
		[Test]
		[ExpectedException( typeof( MessageTypeException ) )]
		public void TestUnpackSByte_Stream_PositiveFixNumMaxValuePlusOneAsUInt8_AsIs()
		{
			using ( var buffer = new MemoryStream( new byte[] { 0xCC, 0x80 } ) )
			{
				var result = Unpacking.UnpackSByte( buffer );
			}
		}
		
		[Test]
		[ExpectedException( typeof( MessageTypeException ) )]
		public void TestUnpackSByte_ByteArray_ByteMaxValueAsInt64_AsIs()
		{
			var result = Unpacking.UnpackSByte( new byte[] { 0xD3, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0xFF } );
		}
		
		[Test]
		[ExpectedException( typeof( MessageTypeException ) )]
		public void TestUnpackSByte_Stream_ByteMaxValueAsInt64_AsIs()
		{
			using ( var buffer = new MemoryStream( new byte[] { 0xD3, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0xFF } ) )
			{
				var result = Unpacking.UnpackSByte( buffer );
			}
		}
		
		[Test]
		[ExpectedException( typeof( MessageTypeException ) )]
		public void TestUnpackSByte_ByteArray_ByteMaxValueAsUInt64_AsIs()
		{
			var result = Unpacking.UnpackSByte( new byte[] { 0xCF, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0xFF } );
		}
		
		[Test]
		[ExpectedException( typeof( MessageTypeException ) )]
		public void TestUnpackSByte_Stream_ByteMaxValueAsUInt64_AsIs()
		{
			using ( var buffer = new MemoryStream( new byte[] { 0xCF, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0xFF } ) )
			{
				var result = Unpacking.UnpackSByte( buffer );
			}
		}
		
		[Test]
		[ExpectedException( typeof( MessageTypeException ) )]
		public void TestUnpackSByte_ByteArray_ByteMaxValueAsInt32_AsIs()
		{
			var result = Unpacking.UnpackSByte( new byte[] { 0xD2, 0x00, 0x00, 0x00, 0xFF } );
		}
		
		[Test]
		[ExpectedException( typeof( MessageTypeException ) )]
		public void TestUnpackSByte_Stream_ByteMaxValueAsInt32_AsIs()
		{
			using ( var buffer = new MemoryStream( new byte[] { 0xD2, 0x00, 0x00, 0x00, 0xFF } ) )
			{
				var result = Unpacking.UnpackSByte( buffer );
			}
		}
		
		[Test]
		[ExpectedException( typeof( MessageTypeException ) )]
		public void TestUnpackSByte_ByteArray_ByteMaxValueAsUInt32_AsIs()
		{
			var result = Unpacking.UnpackSByte( new byte[] { 0xCE, 0x00, 0x00, 0x00, 0xFF } );
		}
		
		[Test]
		[ExpectedException( typeof( MessageTypeException ) )]
		public void TestUnpackSByte_Stream_ByteMaxValueAsUInt32_AsIs()
		{
			using ( var buffer = new MemoryStream( new byte[] { 0xCE, 0x00, 0x00, 0x00, 0xFF } ) )
			{
				var result = Unpacking.UnpackSByte( buffer );
			}
		}
		
		[Test]
		[ExpectedException( typeof( MessageTypeException ) )]
		public void TestUnpackSByte_ByteArray_ByteMaxValueAsInt16_AsIs()
		{
			var result = Unpacking.UnpackSByte( new byte[] { 0xD1, 0x00, 0xFF } );
		}
		
		[Test]
		[ExpectedException( typeof( MessageTypeException ) )]
		public void TestUnpackSByte_Stream_ByteMaxValueAsInt16_AsIs()
		{
			using ( var buffer = new MemoryStream( new byte[] { 0xD1, 0x00, 0xFF } ) )
			{
				var result = Unpacking.UnpackSByte( buffer );
			}
		}
		
		[Test]
		[ExpectedException( typeof( MessageTypeException ) )]
		public void TestUnpackSByte_ByteArray_ByteMaxValueAsUInt16_AsIs()
		{
			var result = Unpacking.UnpackSByte( new byte[] { 0xCD, 0x00, 0xFF } );
		}
		
		[Test]
		[ExpectedException( typeof( MessageTypeException ) )]
		public void TestUnpackSByte_Stream_ByteMaxValueAsUInt16_AsIs()
		{
			using ( var buffer = new MemoryStream( new byte[] { 0xCD, 0x00, 0xFF } ) )
			{
				var result = Unpacking.UnpackSByte( buffer );
			}
		}
		
		[Test]
		[ExpectedException( typeof( MessageTypeException ) )]
		public void TestUnpackSByte_ByteArray_ByteMaxValueAsUInt8_AsIs()
		{
			var result = Unpacking.UnpackSByte( new byte[] { 0xCC, 0xFF } );
		}
		
		[Test]
		[ExpectedException( typeof( MessageTypeException ) )]
		public void TestUnpackSByte_Stream_ByteMaxValueAsUInt8_AsIs()
		{
			using ( var buffer = new MemoryStream( new byte[] { 0xCC, 0xFF } ) )
			{
				var result = Unpacking.UnpackSByte( buffer );
			}
		}
		
		[Test]
		[ExpectedException( typeof( MessageTypeException ) )]
		public void TestUnpackSByte_ByteArray_ByteMaxValuePlusOneAsInt64_AsIs()
		{
			var result = Unpacking.UnpackSByte( new byte[] { 0xD3, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x01, 0x00 } );
		}
		
		[Test]
		[ExpectedException( typeof( MessageTypeException ) )]
		public void TestUnpackSByte_Stream_ByteMaxValuePlusOneAsInt64_AsIs()
		{
			using ( var buffer = new MemoryStream( new byte[] { 0xD3, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x01, 0x00 } ) )
			{
				var result = Unpacking.UnpackSByte( buffer );
			}
		}
		
		[Test]
		[ExpectedException( typeof( MessageTypeException ) )]
		public void TestUnpackSByte_ByteArray_ByteMaxValuePlusOneAsUInt64_AsIs()
		{
			var result = Unpacking.UnpackSByte( new byte[] { 0xCF, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x01, 0x00 } );
		}
		
		[Test]
		[ExpectedException( typeof( MessageTypeException ) )]
		public void TestUnpackSByte_Stream_ByteMaxValuePlusOneAsUInt64_AsIs()
		{
			using ( var buffer = new MemoryStream( new byte[] { 0xCF, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x01, 0x00 } ) )
			{
				var result = Unpacking.UnpackSByte( buffer );
			}
		}
		
		[Test]
		[ExpectedException( typeof( MessageTypeException ) )]
		public void TestUnpackSByte_ByteArray_ByteMaxValuePlusOneAsInt32_AsIs()
		{
			var result = Unpacking.UnpackSByte( new byte[] { 0xD2, 0x00, 0x00, 0x01, 0x00 } );
		}
		
		[Test]
		[ExpectedException( typeof( MessageTypeException ) )]
		public void TestUnpackSByte_Stream_ByteMaxValuePlusOneAsInt32_AsIs()
		{
			using ( var buffer = new MemoryStream( new byte[] { 0xD2, 0x00, 0x00, 0x01, 0x00 } ) )
			{
				var result = Unpacking.UnpackSByte( buffer );
			}
		}
		
		[Test]
		[ExpectedException( typeof( MessageTypeException ) )]
		public void TestUnpackSByte_ByteArray_ByteMaxValuePlusOneAsUInt32_AsIs()
		{
			var result = Unpacking.UnpackSByte( new byte[] { 0xCE, 0x00, 0x00, 0x01, 0x00 } );
		}
		
		[Test]
		[ExpectedException( typeof( MessageTypeException ) )]
		public void TestUnpackSByte_Stream_ByteMaxValuePlusOneAsUInt32_AsIs()
		{
			using ( var buffer = new MemoryStream( new byte[] { 0xCE, 0x00, 0x00, 0x01, 0x00 } ) )
			{
				var result = Unpacking.UnpackSByte( buffer );
			}
		}
		
		[Test]
		[ExpectedException( typeof( MessageTypeException ) )]
		public void TestUnpackSByte_ByteArray_ByteMaxValuePlusOneAsInt16_AsIs()
		{
			var result = Unpacking.UnpackSByte( new byte[] { 0xD1, 0x01, 0x00 } );
		}
		
		[Test]
		[ExpectedException( typeof( MessageTypeException ) )]
		public void TestUnpackSByte_Stream_ByteMaxValuePlusOneAsInt16_AsIs()
		{
			using ( var buffer = new MemoryStream( new byte[] { 0xD1, 0x01, 0x00 } ) )
			{
				var result = Unpacking.UnpackSByte( buffer );
			}
		}
		
		[Test]
		[ExpectedException( typeof( MessageTypeException ) )]
		public void TestUnpackSByte_ByteArray_ByteMaxValuePlusOneAsUInt16_AsIs()
		{
			var result = Unpacking.UnpackSByte( new byte[] { 0xCD, 0x01, 0x00 } );
		}
		
		[Test]
		[ExpectedException( typeof( MessageTypeException ) )]
		public void TestUnpackSByte_Stream_ByteMaxValuePlusOneAsUInt16_AsIs()
		{
			using ( var buffer = new MemoryStream( new byte[] { 0xCD, 0x01, 0x00 } ) )
			{
				var result = Unpacking.UnpackSByte( buffer );
			}
		}
		
		[Test]
		[ExpectedException( typeof( MessageTypeException ) )]
		public void TestUnpackSByte_ByteArray_UInt16MaxValueAsInt64_AsIs()
		{
			var result = Unpacking.UnpackSByte( new byte[] { 0xD3, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0xFF, 0xFF } );
		}
		
		[Test]
		[ExpectedException( typeof( MessageTypeException ) )]
		public void TestUnpackSByte_Stream_UInt16MaxValueAsInt64_AsIs()
		{
			using ( var buffer = new MemoryStream( new byte[] { 0xD3, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0xFF, 0xFF } ) )
			{
				var result = Unpacking.UnpackSByte( buffer );
			}
		}
		
		[Test]
		[ExpectedException( typeof( MessageTypeException ) )]
		public void TestUnpackSByte_ByteArray_UInt16MaxValueAsUInt64_AsIs()
		{
			var result = Unpacking.UnpackSByte( new byte[] { 0xCF, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0xFF, 0xFF } );
		}
		
		[Test]
		[ExpectedException( typeof( MessageTypeException ) )]
		public void TestUnpackSByte_Stream_UInt16MaxValueAsUInt64_AsIs()
		{
			using ( var buffer = new MemoryStream( new byte[] { 0xCF, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0xFF, 0xFF } ) )
			{
				var result = Unpacking.UnpackSByte( buffer );
			}
		}
		
		[Test]
		[ExpectedException( typeof( MessageTypeException ) )]
		public void TestUnpackSByte_ByteArray_UInt16MaxValueAsInt32_AsIs()
		{
			var result = Unpacking.UnpackSByte( new byte[] { 0xD2, 0x00, 0x00, 0xFF, 0xFF } );
		}
		
		[Test]
		[ExpectedException( typeof( MessageTypeException ) )]
		public void TestUnpackSByte_Stream_UInt16MaxValueAsInt32_AsIs()
		{
			using ( var buffer = new MemoryStream( new byte[] { 0xD2, 0x00, 0x00, 0xFF, 0xFF } ) )
			{
				var result = Unpacking.UnpackSByte( buffer );
			}
		}
		
		[Test]
		[ExpectedException( typeof( MessageTypeException ) )]
		public void TestUnpackSByte_ByteArray_UInt16MaxValueAsUInt32_AsIs()
		{
			var result = Unpacking.UnpackSByte( new byte[] { 0xCE, 0x00, 0x00, 0xFF, 0xFF } );
		}
		
		[Test]
		[ExpectedException( typeof( MessageTypeException ) )]
		public void TestUnpackSByte_Stream_UInt16MaxValueAsUInt32_AsIs()
		{
			using ( var buffer = new MemoryStream( new byte[] { 0xCE, 0x00, 0x00, 0xFF, 0xFF } ) )
			{
				var result = Unpacking.UnpackSByte( buffer );
			}
		}
		
		[Test]
		[ExpectedException( typeof( MessageTypeException ) )]
		public void TestUnpackSByte_ByteArray_UInt16MaxValueAsUInt16_AsIs()
		{
			var result = Unpacking.UnpackSByte( new byte[] { 0xCD, 0xFF, 0xFF } );
		}
		
		[Test]
		[ExpectedException( typeof( MessageTypeException ) )]
		public void TestUnpackSByte_Stream_UInt16MaxValueAsUInt16_AsIs()
		{
			using ( var buffer = new MemoryStream( new byte[] { 0xCD, 0xFF, 0xFF } ) )
			{
				var result = Unpacking.UnpackSByte( buffer );
			}
		}
		
		[Test]
		[ExpectedException( typeof( MessageTypeException ) )]
		public void TestUnpackSByte_ByteArray_UInt16MaxValuePlusOneAsInt64_AsIs()
		{
			var result = Unpacking.UnpackSByte( new byte[] { 0xD3, 0x00, 0x00, 0x00, 0x00, 0x00, 0x01, 0x00, 0x00 } );
		}
		
		[Test]
		[ExpectedException( typeof( MessageTypeException ) )]
		public void TestUnpackSByte_Stream_UInt16MaxValuePlusOneAsInt64_AsIs()
		{
			using ( var buffer = new MemoryStream( new byte[] { 0xD3, 0x00, 0x00, 0x00, 0x00, 0x00, 0x01, 0x00, 0x00 } ) )
			{
				var result = Unpacking.UnpackSByte( buffer );
			}
		}
		
		[Test]
		[ExpectedException( typeof( MessageTypeException ) )]
		public void TestUnpackSByte_ByteArray_UInt16MaxValuePlusOneAsUInt64_AsIs()
		{
			var result = Unpacking.UnpackSByte( new byte[] { 0xCF, 0x00, 0x00, 0x00, 0x00, 0x00, 0x01, 0x00, 0x00 } );
		}
		
		[Test]
		[ExpectedException( typeof( MessageTypeException ) )]
		public void TestUnpackSByte_Stream_UInt16MaxValuePlusOneAsUInt64_AsIs()
		{
			using ( var buffer = new MemoryStream( new byte[] { 0xCF, 0x00, 0x00, 0x00, 0x00, 0x00, 0x01, 0x00, 0x00 } ) )
			{
				var result = Unpacking.UnpackSByte( buffer );
			}
		}
		
		[Test]
		[ExpectedException( typeof( MessageTypeException ) )]
		public void TestUnpackSByte_ByteArray_UInt16MaxValuePlusOneAsInt32_AsIs()
		{
			var result = Unpacking.UnpackSByte( new byte[] { 0xD2, 0x00, 0x01, 0x00, 0x00 } );
		}
		
		[Test]
		[ExpectedException( typeof( MessageTypeException ) )]
		public void TestUnpackSByte_Stream_UInt16MaxValuePlusOneAsInt32_AsIs()
		{
			using ( var buffer = new MemoryStream( new byte[] { 0xD2, 0x00, 0x01, 0x00, 0x00 } ) )
			{
				var result = Unpacking.UnpackSByte( buffer );
			}
		}
		
		[Test]
		[ExpectedException( typeof( MessageTypeException ) )]
		public void TestUnpackSByte_ByteArray_UInt16MaxValuePlusOneAsUInt32_AsIs()
		{
			var result = Unpacking.UnpackSByte( new byte[] { 0xCE, 0x00, 0x01, 0x00, 0x00 } );
		}
		
		[Test]
		[ExpectedException( typeof( MessageTypeException ) )]
		public void TestUnpackSByte_Stream_UInt16MaxValuePlusOneAsUInt32_AsIs()
		{
			using ( var buffer = new MemoryStream( new byte[] { 0xCE, 0x00, 0x01, 0x00, 0x00 } ) )
			{
				var result = Unpacking.UnpackSByte( buffer );
			}
		}
		
		[Test]
		[ExpectedException( typeof( MessageTypeException ) )]
		public void TestUnpackSByte_ByteArray_UInt32MaxValueAsInt64_AsIs()
		{
			var result = Unpacking.UnpackSByte( new byte[] { 0xD3, 0x00, 0x00, 0x00, 0x00, 0xFF, 0xFF, 0xFF, 0xFF } );
		}
		
		[Test]
		[ExpectedException( typeof( MessageTypeException ) )]
		public void TestUnpackSByte_Stream_UInt32MaxValueAsInt64_AsIs()
		{
			using ( var buffer = new MemoryStream( new byte[] { 0xD3, 0x00, 0x00, 0x00, 0x00, 0xFF, 0xFF, 0xFF, 0xFF } ) )
			{
				var result = Unpacking.UnpackSByte( buffer );
			}
		}
		
		[Test]
		[ExpectedException( typeof( MessageTypeException ) )]
		public void TestUnpackSByte_ByteArray_UInt32MaxValueAsUInt64_AsIs()
		{
			var result = Unpacking.UnpackSByte( new byte[] { 0xCF, 0x00, 0x00, 0x00, 0x00, 0xFF, 0xFF, 0xFF, 0xFF } );
		}
		
		[Test]
		[ExpectedException( typeof( MessageTypeException ) )]
		public void TestUnpackSByte_Stream_UInt32MaxValueAsUInt64_AsIs()
		{
			using ( var buffer = new MemoryStream( new byte[] { 0xCF, 0x00, 0x00, 0x00, 0x00, 0xFF, 0xFF, 0xFF, 0xFF } ) )
			{
				var result = Unpacking.UnpackSByte( buffer );
			}
		}
		
		[Test]
		[ExpectedException( typeof( MessageTypeException ) )]
		public void TestUnpackSByte_ByteArray_UInt32MaxValueAsUInt32_AsIs()
		{
			var result = Unpacking.UnpackSByte( new byte[] { 0xCE, 0xFF, 0xFF, 0xFF, 0xFF } );
		}
		
		[Test]
		[ExpectedException( typeof( MessageTypeException ) )]
		public void TestUnpackSByte_Stream_UInt32MaxValueAsUInt32_AsIs()
		{
			using ( var buffer = new MemoryStream( new byte[] { 0xCE, 0xFF, 0xFF, 0xFF, 0xFF } ) )
			{
				var result = Unpacking.UnpackSByte( buffer );
			}
		}
		
		[Test]
		[ExpectedException( typeof( MessageTypeException ) )]
		public void TestUnpackSByte_ByteArray_UInt32MaxValuePlusOneAsInt64_AsIs()
		{
			var result = Unpacking.UnpackSByte( new byte[] { 0xD3, 0x00, 0x00, 0x00, 0x01, 0x00, 0x00, 0x00, 0x00 } );
		}
		
		[Test]
		[ExpectedException( typeof( MessageTypeException ) )]
		public void TestUnpackSByte_Stream_UInt32MaxValuePlusOneAsInt64_AsIs()
		{
			using ( var buffer = new MemoryStream( new byte[] { 0xD3, 0x00, 0x00, 0x00, 0x01, 0x00, 0x00, 0x00, 0x00 } ) )
			{
				var result = Unpacking.UnpackSByte( buffer );
			}
		}
		
		[Test]
		[ExpectedException( typeof( MessageTypeException ) )]
		public void TestUnpackSByte_ByteArray_UInt32MaxValuePlusOneAsUInt64_AsIs()
		{
			var result = Unpacking.UnpackSByte( new byte[] { 0xCF, 0x00, 0x00, 0x00, 0x01, 0x00, 0x00, 0x00, 0x00 } );
		}
		
		[Test]
		[ExpectedException( typeof( MessageTypeException ) )]
		public void TestUnpackSByte_Stream_UInt32MaxValuePlusOneAsUInt64_AsIs()
		{
			using ( var buffer = new MemoryStream( new byte[] { 0xCF, 0x00, 0x00, 0x00, 0x01, 0x00, 0x00, 0x00, 0x00 } ) )
			{
				var result = Unpacking.UnpackSByte( buffer );
			}
		}
		
		[Test]
		[ExpectedException( typeof( MessageTypeException ) )]
		public void TestUnpackSByte_ByteArray_UInt64MaxValueAsUInt64_AsIs()
		{
			var result = Unpacking.UnpackSByte( new byte[] { 0xCF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF } );
		}
		
		[Test]
		[ExpectedException( typeof( MessageTypeException ) )]
		public void TestUnpackSByte_Stream_UInt64MaxValueAsUInt64_AsIs()
		{
			using ( var buffer = new MemoryStream( new byte[] { 0xCF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF } ) )
			{
				var result = Unpacking.UnpackSByte( buffer );
			}
		}
		
		[Test]
		[ExpectedException( typeof( ArgumentException ) )]
		public void TestUnpackSByte_ByteArray_Empty()
		{
			Unpacking.UnpackSByte( new byte[ 0 ] );
		}

		[Test]
		[ExpectedException( typeof( ArgumentNullException ) )]
		public void TestUnpackSByte_ByteArray_Null()
		{
			Unpacking.UnpackSByte( default( byte[] ) );
		}

		[Test]
		[ExpectedException( typeof( ArgumentNullException ) )]
		public void TestUnpackSByte_ByteArray_Offset_Null()
		{
			Unpacking.UnpackSByte( default( byte[] ), 0 );
		}

		[Test]
		[ExpectedException( typeof( ArgumentOutOfRangeException ) )]
		public void TestUnpackSByte_ByteArray_Offset_OffsetIsNegative()
		{
			Unpacking.UnpackSByte( new byte[]{ 0x1 }, -1 );
		}

		[Test]
		[ExpectedException( typeof( ArgumentException ) )]
		public void TestUnpackSByte_ByteArray_Offset_OffsetIsTooBig()
		{
			Unpacking.UnpackSByte( new byte[]{ 0x1 }, 1 );
		}

		[Test]
		[ExpectedException( typeof( ArgumentException ) )]
		public void TestUnpackSByte_ByteArray_Offset_Empty()
		{
			Unpacking.UnpackSByte( new byte[ 0 ], 0 );
		}

		[Test]
		[ExpectedException( typeof( ArgumentNullException ) )]
		public void TestUnpackSByte_Stream_Null()
		{
			Unpacking.UnpackSByte( default( Stream ) );
		}

		[Test]
		public void TestUnpackSByte_ByteArray_Offset_OffsetIsValid_OffsetIsRespected()
		{
			// Offset 1 is positive fix num 1.
			var result = Unpacking.UnpackSByte( new byte[] { 0xFF, 0x57, 0xFF }, 1 );
			Assert.AreEqual( 1, result.ReadCount );
			Assert.AreEqual( 0x57, result.Value );
		}

		[Test]
		[ExpectedException( typeof( MessageTypeException ) )]
		public void TestUnpackSByte_ByteArray_Null_Nil()
		{
			Unpacking.UnpackSByte( new byte[] { 0xC0 } );
		}
	
		[Test]
		[ExpectedException( typeof( MessageTypeException ) )]
		public void TestUnpackSByte_ByteArray_NotSByte()
		{
			Unpacking.UnpackSByte( new byte[] { 0xA0 } );
		}
	}

	partial class UnpackingTest_Combinations_Byte
	{
		[Test]
		[ExpectedException( typeof( MessageTypeException ) )]
		public void TestUnpackByte_ByteArray_Int64MinValueAsInt64_AsIs()
		{
			var result = Unpacking.UnpackByte( new byte[] { 0xD3, 0x80, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 } );
		}
		
		[Test]
		[ExpectedException( typeof( MessageTypeException ) )]
		public void TestUnpackByte_Stream_Int64MinValueAsInt64_AsIs()
		{
			using ( var buffer = new MemoryStream( new byte[] { 0xD3, 0x80, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 } ) )
			{
				var result = Unpacking.UnpackByte( buffer );
			}
		}
		
		[Test]
		[ExpectedException( typeof( MessageTypeException ) )]
		public void TestUnpackByte_ByteArray_Int32MinValueMinusOneAsInt64_AsIs()
		{
			var result = Unpacking.UnpackByte( new byte[] { 0xD3, 0xFF, 0xFF, 0xFF, 0xFF, 0x7F, 0xFF, 0xFF, 0xFF } );
		}
		
		[Test]
		[ExpectedException( typeof( MessageTypeException ) )]
		public void TestUnpackByte_Stream_Int32MinValueMinusOneAsInt64_AsIs()
		{
			using ( var buffer = new MemoryStream( new byte[] { 0xD3, 0xFF, 0xFF, 0xFF, 0xFF, 0x7F, 0xFF, 0xFF, 0xFF } ) )
			{
				var result = Unpacking.UnpackByte( buffer );
			}
		}
		
		[Test]
		[ExpectedException( typeof( MessageTypeException ) )]
		public void TestUnpackByte_ByteArray_Int32MinValueAsInt64_AsIs()
		{
			var result = Unpacking.UnpackByte( new byte[] { 0xD3, 0xFF, 0xFF, 0xFF, 0xFF, 0x80, 0x00, 0x00, 0x00 } );
		}
		
		[Test]
		[ExpectedException( typeof( MessageTypeException ) )]
		public void TestUnpackByte_Stream_Int32MinValueAsInt64_AsIs()
		{
			using ( var buffer = new MemoryStream( new byte[] { 0xD3, 0xFF, 0xFF, 0xFF, 0xFF, 0x80, 0x00, 0x00, 0x00 } ) )
			{
				var result = Unpacking.UnpackByte( buffer );
			}
		}
		
		[Test]
		[ExpectedException( typeof( MessageTypeException ) )]
		public void TestUnpackByte_ByteArray_Int32MinValueAsInt32_AsIs()
		{
			var result = Unpacking.UnpackByte( new byte[] { 0xD2, 0x80, 0x00, 0x00, 0x00 } );
		}
		
		[Test]
		[ExpectedException( typeof( MessageTypeException ) )]
		public void TestUnpackByte_Stream_Int32MinValueAsInt32_AsIs()
		{
			using ( var buffer = new MemoryStream( new byte[] { 0xD2, 0x80, 0x00, 0x00, 0x00 } ) )
			{
				var result = Unpacking.UnpackByte( buffer );
			}
		}
		
		[Test]
		[ExpectedException( typeof( MessageTypeException ) )]
		public void TestUnpackByte_ByteArray_Int16MinValueMinusOneAsInt64_AsIs()
		{
			var result = Unpacking.UnpackByte( new byte[] { 0xD3, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0x7F, 0xFF } );
		}
		
		[Test]
		[ExpectedException( typeof( MessageTypeException ) )]
		public void TestUnpackByte_Stream_Int16MinValueMinusOneAsInt64_AsIs()
		{
			using ( var buffer = new MemoryStream( new byte[] { 0xD3, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0x7F, 0xFF } ) )
			{
				var result = Unpacking.UnpackByte( buffer );
			}
		}
		
		[Test]
		[ExpectedException( typeof( MessageTypeException ) )]
		public void TestUnpackByte_ByteArray_Int16MinValueMinusOneAsInt32_AsIs()
		{
			var result = Unpacking.UnpackByte( new byte[] { 0xD2, 0xFF, 0xFF, 0x7F, 0xFF } );
		}
		
		[Test]
		[ExpectedException( typeof( MessageTypeException ) )]
		public void TestUnpackByte_Stream_Int16MinValueMinusOneAsInt32_AsIs()
		{
			using ( var buffer = new MemoryStream( new byte[] { 0xD2, 0xFF, 0xFF, 0x7F, 0xFF } ) )
			{
				var result = Unpacking.UnpackByte( buffer );
			}
		}
		
		[Test]
		[ExpectedException( typeof( MessageTypeException ) )]
		public void TestUnpackByte_ByteArray_Int16MinValueAsInt64_AsIs()
		{
			var result = Unpacking.UnpackByte( new byte[] { 0xD3, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0x80, 0x00 } );
		}
		
		[Test]
		[ExpectedException( typeof( MessageTypeException ) )]
		public void TestUnpackByte_Stream_Int16MinValueAsInt64_AsIs()
		{
			using ( var buffer = new MemoryStream( new byte[] { 0xD3, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0x80, 0x00 } ) )
			{
				var result = Unpacking.UnpackByte( buffer );
			}
		}
		
		[Test]
		[ExpectedException( typeof( MessageTypeException ) )]
		public void TestUnpackByte_ByteArray_Int16MinValueAsInt32_AsIs()
		{
			var result = Unpacking.UnpackByte( new byte[] { 0xD2, 0xFF, 0xFF, 0x80, 0x00 } );
		}
		
		[Test]
		[ExpectedException( typeof( MessageTypeException ) )]
		public void TestUnpackByte_Stream_Int16MinValueAsInt32_AsIs()
		{
			using ( var buffer = new MemoryStream( new byte[] { 0xD2, 0xFF, 0xFF, 0x80, 0x00 } ) )
			{
				var result = Unpacking.UnpackByte( buffer );
			}
		}
		
		[Test]
		[ExpectedException( typeof( MessageTypeException ) )]
		public void TestUnpackByte_ByteArray_Int16MinValueAsInt16_AsIs()
		{
			var result = Unpacking.UnpackByte( new byte[] { 0xD1, 0x80, 0x00 } );
		}
		
		[Test]
		[ExpectedException( typeof( MessageTypeException ) )]
		public void TestUnpackByte_Stream_Int16MinValueAsInt16_AsIs()
		{
			using ( var buffer = new MemoryStream( new byte[] { 0xD1, 0x80, 0x00 } ) )
			{
				var result = Unpacking.UnpackByte( buffer );
			}
		}
		
		[Test]
		[ExpectedException( typeof( MessageTypeException ) )]
		public void TestUnpackByte_ByteArray_SByteMinValueMinusOneAsInt64_AsIs()
		{
			var result = Unpacking.UnpackByte( new byte[] { 0xD3, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0x7F } );
		}
		
		[Test]
		[ExpectedException( typeof( MessageTypeException ) )]
		public void TestUnpackByte_Stream_SByteMinValueMinusOneAsInt64_AsIs()
		{
			using ( var buffer = new MemoryStream( new byte[] { 0xD3, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0x7F } ) )
			{
				var result = Unpacking.UnpackByte( buffer );
			}
		}
		
		[Test]
		[ExpectedException( typeof( MessageTypeException ) )]
		public void TestUnpackByte_ByteArray_SByteMinValueMinusOneAsInt32_AsIs()
		{
			var result = Unpacking.UnpackByte( new byte[] { 0xD2, 0xFF, 0xFF, 0xFF, 0x7F } );
		}
		
		[Test]
		[ExpectedException( typeof( MessageTypeException ) )]
		public void TestUnpackByte_Stream_SByteMinValueMinusOneAsInt32_AsIs()
		{
			using ( var buffer = new MemoryStream( new byte[] { 0xD2, 0xFF, 0xFF, 0xFF, 0x7F } ) )
			{
				var result = Unpacking.UnpackByte( buffer );
			}
		}
		
		[Test]
		[ExpectedException( typeof( MessageTypeException ) )]
		public void TestUnpackByte_ByteArray_SByteMinValueMinusOneAsInt16_AsIs()
		{
			var result = Unpacking.UnpackByte( new byte[] { 0xD1, 0xFF, 0x7F } );
		}
		
		[Test]
		[ExpectedException( typeof( MessageTypeException ) )]
		public void TestUnpackByte_Stream_SByteMinValueMinusOneAsInt16_AsIs()
		{
			using ( var buffer = new MemoryStream( new byte[] { 0xD1, 0xFF, 0x7F } ) )
			{
				var result = Unpacking.UnpackByte( buffer );
			}
		}
		
		[Test]
		[ExpectedException( typeof( MessageTypeException ) )]
		public void TestUnpackByte_ByteArray_SByteMinValueAsInt64_AsIs()
		{
			var result = Unpacking.UnpackByte( new byte[] { 0xD3, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0x80 } );
		}
		
		[Test]
		[ExpectedException( typeof( MessageTypeException ) )]
		public void TestUnpackByte_Stream_SByteMinValueAsInt64_AsIs()
		{
			using ( var buffer = new MemoryStream( new byte[] { 0xD3, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0x80 } ) )
			{
				var result = Unpacking.UnpackByte( buffer );
			}
		}
		
		[Test]
		[ExpectedException( typeof( MessageTypeException ) )]
		public void TestUnpackByte_ByteArray_SByteMinValueAsInt32_AsIs()
		{
			var result = Unpacking.UnpackByte( new byte[] { 0xD2, 0xFF, 0xFF, 0xFF, 0x80 } );
		}
		
		[Test]
		[ExpectedException( typeof( MessageTypeException ) )]
		public void TestUnpackByte_Stream_SByteMinValueAsInt32_AsIs()
		{
			using ( var buffer = new MemoryStream( new byte[] { 0xD2, 0xFF, 0xFF, 0xFF, 0x80 } ) )
			{
				var result = Unpacking.UnpackByte( buffer );
			}
		}
		
		[Test]
		[ExpectedException( typeof( MessageTypeException ) )]
		public void TestUnpackByte_ByteArray_SByteMinValueAsInt16_AsIs()
		{
			var result = Unpacking.UnpackByte( new byte[] { 0xD1, 0xFF, 0x80 } );
		}
		
		[Test]
		[ExpectedException( typeof( MessageTypeException ) )]
		public void TestUnpackByte_Stream_SByteMinValueAsInt16_AsIs()
		{
			using ( var buffer = new MemoryStream( new byte[] { 0xD1, 0xFF, 0x80 } ) )
			{
				var result = Unpacking.UnpackByte( buffer );
			}
		}
		
		[Test]
		[ExpectedException( typeof( MessageTypeException ) )]
		public void TestUnpackByte_ByteArray_SByteMinValueAsInt8_AsIs()
		{
			var result = Unpacking.UnpackByte( new byte[] { 0xD0, 0x80 } );
		}
		
		[Test]
		[ExpectedException( typeof( MessageTypeException ) )]
		public void TestUnpackByte_Stream_SByteMinValueAsInt8_AsIs()
		{
			using ( var buffer = new MemoryStream( new byte[] { 0xD0, 0x80 } ) )
			{
				var result = Unpacking.UnpackByte( buffer );
			}
		}
		
		[Test]
		[ExpectedException( typeof( MessageTypeException ) )]
		public void TestUnpackByte_ByteArray_NegativeFixNumMinValueMinusOneAsInt64_AsIs()
		{
			var result = Unpacking.UnpackByte( new byte[] { 0xD3, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xDF } );
		}
		
		[Test]
		[ExpectedException( typeof( MessageTypeException ) )]
		public void TestUnpackByte_Stream_NegativeFixNumMinValueMinusOneAsInt64_AsIs()
		{
			using ( var buffer = new MemoryStream( new byte[] { 0xD3, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xDF } ) )
			{
				var result = Unpacking.UnpackByte( buffer );
			}
		}
		
		[Test]
		[ExpectedException( typeof( MessageTypeException ) )]
		public void TestUnpackByte_ByteArray_NegativeFixNumMinValueMinusOneAsInt32_AsIs()
		{
			var result = Unpacking.UnpackByte( new byte[] { 0xD2, 0xFF, 0xFF, 0xFF, 0xDF } );
		}
		
		[Test]
		[ExpectedException( typeof( MessageTypeException ) )]
		public void TestUnpackByte_Stream_NegativeFixNumMinValueMinusOneAsInt32_AsIs()
		{
			using ( var buffer = new MemoryStream( new byte[] { 0xD2, 0xFF, 0xFF, 0xFF, 0xDF } ) )
			{
				var result = Unpacking.UnpackByte( buffer );
			}
		}
		
		[Test]
		[ExpectedException( typeof( MessageTypeException ) )]
		public void TestUnpackByte_ByteArray_NegativeFixNumMinValueMinusOneAsInt16_AsIs()
		{
			var result = Unpacking.UnpackByte( new byte[] { 0xD1, 0xFF, 0xDF } );
		}
		
		[Test]
		[ExpectedException( typeof( MessageTypeException ) )]
		public void TestUnpackByte_Stream_NegativeFixNumMinValueMinusOneAsInt16_AsIs()
		{
			using ( var buffer = new MemoryStream( new byte[] { 0xD1, 0xFF, 0xDF } ) )
			{
				var result = Unpacking.UnpackByte( buffer );
			}
		}
		
		[Test]
		[ExpectedException( typeof( MessageTypeException ) )]
		public void TestUnpackByte_ByteArray_NegativeFixNumMinValueMinusOneAsInt8_AsIs()
		{
			var result = Unpacking.UnpackByte( new byte[] { 0xD0, 0xDF } );
		}
		
		[Test]
		[ExpectedException( typeof( MessageTypeException ) )]
		public void TestUnpackByte_Stream_NegativeFixNumMinValueMinusOneAsInt8_AsIs()
		{
			using ( var buffer = new MemoryStream( new byte[] { 0xD0, 0xDF } ) )
			{
				var result = Unpacking.UnpackByte( buffer );
			}
		}
		
		[Test]
		[ExpectedException( typeof( MessageTypeException ) )]
		public void TestUnpackByte_ByteArray_NegativeFixNumMinValueAsInt64_AsIs()
		{
			var result = Unpacking.UnpackByte( new byte[] { 0xD3, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xE0 } );
		}
		
		[Test]
		[ExpectedException( typeof( MessageTypeException ) )]
		public void TestUnpackByte_Stream_NegativeFixNumMinValueAsInt64_AsIs()
		{
			using ( var buffer = new MemoryStream( new byte[] { 0xD3, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xE0 } ) )
			{
				var result = Unpacking.UnpackByte( buffer );
			}
		}
		
		[Test]
		[ExpectedException( typeof( MessageTypeException ) )]
		public void TestUnpackByte_ByteArray_NegativeFixNumMinValueAsInt32_AsIs()
		{
			var result = Unpacking.UnpackByte( new byte[] { 0xD2, 0xFF, 0xFF, 0xFF, 0xE0 } );
		}
		
		[Test]
		[ExpectedException( typeof( MessageTypeException ) )]
		public void TestUnpackByte_Stream_NegativeFixNumMinValueAsInt32_AsIs()
		{
			using ( var buffer = new MemoryStream( new byte[] { 0xD2, 0xFF, 0xFF, 0xFF, 0xE0 } ) )
			{
				var result = Unpacking.UnpackByte( buffer );
			}
		}
		
		[Test]
		[ExpectedException( typeof( MessageTypeException ) )]
		public void TestUnpackByte_ByteArray_NegativeFixNumMinValueAsInt16_AsIs()
		{
			var result = Unpacking.UnpackByte( new byte[] { 0xD1, 0xFF, 0xE0 } );
		}
		
		[Test]
		[ExpectedException( typeof( MessageTypeException ) )]
		public void TestUnpackByte_Stream_NegativeFixNumMinValueAsInt16_AsIs()
		{
			using ( var buffer = new MemoryStream( new byte[] { 0xD1, 0xFF, 0xE0 } ) )
			{
				var result = Unpacking.UnpackByte( buffer );
			}
		}
		
		[Test]
		[ExpectedException( typeof( MessageTypeException ) )]
		public void TestUnpackByte_ByteArray_NegativeFixNumMinValueAsInt8_AsIs()
		{
			var result = Unpacking.UnpackByte( new byte[] { 0xD0, 0xE0 } );
		}
		
		[Test]
		[ExpectedException( typeof( MessageTypeException ) )]
		public void TestUnpackByte_Stream_NegativeFixNumMinValueAsInt8_AsIs()
		{
			using ( var buffer = new MemoryStream( new byte[] { 0xD0, 0xE0 } ) )
			{
				var result = Unpacking.UnpackByte( buffer );
			}
		}
		
		[Test]
		[ExpectedException( typeof( MessageTypeException ) )]
		public void TestUnpackByte_ByteArray_NegativeFixNumMinValueAsNegativeFixNumMinus32_AsIs()
		{
			var result = Unpacking.UnpackByte( new byte[] { 0xE0 } );
		}
		
		[Test]
		[ExpectedException( typeof( MessageTypeException ) )]
		public void TestUnpackByte_Stream_NegativeFixNumMinValueAsNegativeFixNumMinus32_AsIs()
		{
			using ( var buffer = new MemoryStream( new byte[] { 0xE0 } ) )
			{
				var result = Unpacking.UnpackByte( buffer );
			}
		}
		
		[Test]
		[ExpectedException( typeof( MessageTypeException ) )]
		public void TestUnpackByte_ByteArray_MinusOneAsInt64_AsIs()
		{
			var result = Unpacking.UnpackByte( new byte[] { 0xD3, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF } );
		}
		
		[Test]
		[ExpectedException( typeof( MessageTypeException ) )]
		public void TestUnpackByte_Stream_MinusOneAsInt64_AsIs()
		{
			using ( var buffer = new MemoryStream( new byte[] { 0xD3, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF } ) )
			{
				var result = Unpacking.UnpackByte( buffer );
			}
		}
		
		[Test]
		[ExpectedException( typeof( MessageTypeException ) )]
		public void TestUnpackByte_ByteArray_MinusOneAsInt32_AsIs()
		{
			var result = Unpacking.UnpackByte( new byte[] { 0xD2, 0xFF, 0xFF, 0xFF, 0xFF } );
		}
		
		[Test]
		[ExpectedException( typeof( MessageTypeException ) )]
		public void TestUnpackByte_Stream_MinusOneAsInt32_AsIs()
		{
			using ( var buffer = new MemoryStream( new byte[] { 0xD2, 0xFF, 0xFF, 0xFF, 0xFF } ) )
			{
				var result = Unpacking.UnpackByte( buffer );
			}
		}
		
		[Test]
		[ExpectedException( typeof( MessageTypeException ) )]
		public void TestUnpackByte_ByteArray_MinusOneAsInt16_AsIs()
		{
			var result = Unpacking.UnpackByte( new byte[] { 0xD1, 0xFF, 0xFF } );
		}
		
		[Test]
		[ExpectedException( typeof( MessageTypeException ) )]
		public void TestUnpackByte_Stream_MinusOneAsInt16_AsIs()
		{
			using ( var buffer = new MemoryStream( new byte[] { 0xD1, 0xFF, 0xFF } ) )
			{
				var result = Unpacking.UnpackByte( buffer );
			}
		}
		
		[Test]
		[ExpectedException( typeof( MessageTypeException ) )]
		public void TestUnpackByte_ByteArray_MinusOneAsInt8_AsIs()
		{
			var result = Unpacking.UnpackByte( new byte[] { 0xD0, 0xFF } );
		}
		
		[Test]
		[ExpectedException( typeof( MessageTypeException ) )]
		public void TestUnpackByte_Stream_MinusOneAsInt8_AsIs()
		{
			using ( var buffer = new MemoryStream( new byte[] { 0xD0, 0xFF } ) )
			{
				var result = Unpacking.UnpackByte( buffer );
			}
		}
		
		[Test]
		[ExpectedException( typeof( MessageTypeException ) )]
		public void TestUnpackByte_ByteArray_MinusOneAsNegativeFixNumMinus1_AsIs()
		{
			var result = Unpacking.UnpackByte( new byte[] { 0xFF } );
		}
		
		[Test]
		[ExpectedException( typeof( MessageTypeException ) )]
		public void TestUnpackByte_Stream_MinusOneAsNegativeFixNumMinus1_AsIs()
		{
			using ( var buffer = new MemoryStream( new byte[] { 0xFF } ) )
			{
				var result = Unpacking.UnpackByte( buffer );
			}
		}
		
		[Test]
		public void TestUnpackByte_ByteArray_ZeroAsInt64_Fail()
		{
			var result = Unpacking.UnpackByte( new byte[] { 0xD3, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 } );
			Assert.AreEqual( 9, result.ReadCount );
			Assert.AreEqual( 0L, result.Value );
		}
		
		[Test]
		public void TestUnpackByte_Stream_ZeroAsInt64_Fail()
		{
			using ( var buffer = new MemoryStream( new byte[] { 0xD3, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 } ) )
			{
				var result = Unpacking.UnpackByte( buffer );
				Assert.AreEqual( 9, buffer.Position );
				Assert.AreEqual( 0L, result );
			}
		}
		
		[Test]
		public void TestUnpackByte_ByteArray_ZeroAsUInt64_Fail()
		{
			var result = Unpacking.UnpackByte( new byte[] { 0xCF, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 } );
			Assert.AreEqual( 9, result.ReadCount );
			Assert.AreEqual( 0L, result.Value );
		}
		
		[Test]
		public void TestUnpackByte_Stream_ZeroAsUInt64_Fail()
		{
			using ( var buffer = new MemoryStream( new byte[] { 0xCF, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 } ) )
			{
				var result = Unpacking.UnpackByte( buffer );
				Assert.AreEqual( 9, buffer.Position );
				Assert.AreEqual( 0L, result );
			}
		}
		
		[Test]
		public void TestUnpackByte_ByteArray_ZeroAsInt32_Fail()
		{
			var result = Unpacking.UnpackByte( new byte[] { 0xD2, 0x00, 0x00, 0x00, 0x00 } );
			Assert.AreEqual( 5, result.ReadCount );
			Assert.AreEqual( 0L, result.Value );
		}
		
		[Test]
		public void TestUnpackByte_Stream_ZeroAsInt32_Fail()
		{
			using ( var buffer = new MemoryStream( new byte[] { 0xD2, 0x00, 0x00, 0x00, 0x00 } ) )
			{
				var result = Unpacking.UnpackByte( buffer );
				Assert.AreEqual( 5, buffer.Position );
				Assert.AreEqual( 0L, result );
			}
		}
		
		[Test]
		public void TestUnpackByte_ByteArray_ZeroAsUInt32_Fail()
		{
			var result = Unpacking.UnpackByte( new byte[] { 0xCE, 0x00, 0x00, 0x00, 0x00 } );
			Assert.AreEqual( 5, result.ReadCount );
			Assert.AreEqual( 0L, result.Value );
		}
		
		[Test]
		public void TestUnpackByte_Stream_ZeroAsUInt32_Fail()
		{
			using ( var buffer = new MemoryStream( new byte[] { 0xCE, 0x00, 0x00, 0x00, 0x00 } ) )
			{
				var result = Unpacking.UnpackByte( buffer );
				Assert.AreEqual( 5, buffer.Position );
				Assert.AreEqual( 0L, result );
			}
		}
		
		[Test]
		public void TestUnpackByte_ByteArray_ZeroAsInt16_Fail()
		{
			var result = Unpacking.UnpackByte( new byte[] { 0xD1, 0x00, 0x00 } );
			Assert.AreEqual( 3, result.ReadCount );
			Assert.AreEqual( 0L, result.Value );
		}
		
		[Test]
		public void TestUnpackByte_Stream_ZeroAsInt16_Fail()
		{
			using ( var buffer = new MemoryStream( new byte[] { 0xD1, 0x00, 0x00 } ) )
			{
				var result = Unpacking.UnpackByte( buffer );
				Assert.AreEqual( 3, buffer.Position );
				Assert.AreEqual( 0L, result );
			}
		}
		
		[Test]
		public void TestUnpackByte_ByteArray_ZeroAsUInt16_Fail()
		{
			var result = Unpacking.UnpackByte( new byte[] { 0xCD, 0x00, 0x00 } );
			Assert.AreEqual( 3, result.ReadCount );
			Assert.AreEqual( 0L, result.Value );
		}
		
		[Test]
		public void TestUnpackByte_Stream_ZeroAsUInt16_Fail()
		{
			using ( var buffer = new MemoryStream( new byte[] { 0xCD, 0x00, 0x00 } ) )
			{
				var result = Unpacking.UnpackByte( buffer );
				Assert.AreEqual( 3, buffer.Position );
				Assert.AreEqual( 0L, result );
			}
		}
		
		[Test]
		public void TestUnpackByte_ByteArray_ZeroAsInt8_Fail()
		{
			var result = Unpacking.UnpackByte( new byte[] { 0xD0, 0x00 } );
			Assert.AreEqual( 2, result.ReadCount );
			Assert.AreEqual( 0L, result.Value );
		}
		
		[Test]
		public void TestUnpackByte_Stream_ZeroAsInt8_Fail()
		{
			using ( var buffer = new MemoryStream( new byte[] { 0xD0, 0x00 } ) )
			{
				var result = Unpacking.UnpackByte( buffer );
				Assert.AreEqual( 2, buffer.Position );
				Assert.AreEqual( 0L, result );
			}
		}
		
		[Test]
		public void TestUnpackByte_ByteArray_ZeroAsUInt8_Fail()
		{
			var result = Unpacking.UnpackByte( new byte[] { 0xCC, 0x00 } );
			Assert.AreEqual( 2, result.ReadCount );
			Assert.AreEqual( 0L, result.Value );
		}
		
		[Test]
		public void TestUnpackByte_Stream_ZeroAsUInt8_Fail()
		{
			using ( var buffer = new MemoryStream( new byte[] { 0xCC, 0x00 } ) )
			{
				var result = Unpacking.UnpackByte( buffer );
				Assert.AreEqual( 2, buffer.Position );
				Assert.AreEqual( 0L, result );
			}
		}
		
		[Test]
		public void TestUnpackByte_ByteArray_ZeroAsPositiveFixNum0_Fail()
		{
			var result = Unpacking.UnpackByte( new byte[] { 0x00 } );
			Assert.AreEqual( 1, result.ReadCount );
			Assert.AreEqual( 0L, result.Value );
		}
		
		[Test]
		public void TestUnpackByte_Stream_ZeroAsPositiveFixNum0_Fail()
		{
			using ( var buffer = new MemoryStream( new byte[] { 0x00 } ) )
			{
				var result = Unpacking.UnpackByte( buffer );
				Assert.AreEqual( 1, buffer.Position );
				Assert.AreEqual( 0L, result );
			}
		}
		
		[Test]
		public void TestUnpackByte_ByteArray_PlusOneAsInt64_Fail()
		{
			var result = Unpacking.UnpackByte( new byte[] { 0xD3, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x01 } );
			Assert.AreEqual( 9, result.ReadCount );
			Assert.AreEqual( 1L, result.Value );
		}
		
		[Test]
		public void TestUnpackByte_Stream_PlusOneAsInt64_Fail()
		{
			using ( var buffer = new MemoryStream( new byte[] { 0xD3, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x01 } ) )
			{
				var result = Unpacking.UnpackByte( buffer );
				Assert.AreEqual( 9, buffer.Position );
				Assert.AreEqual( 1L, result );
			}
		}
		
		[Test]
		public void TestUnpackByte_ByteArray_PlusOneAsUInt64_Fail()
		{
			var result = Unpacking.UnpackByte( new byte[] { 0xCF, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x01 } );
			Assert.AreEqual( 9, result.ReadCount );
			Assert.AreEqual( 1L, result.Value );
		}
		
		[Test]
		public void TestUnpackByte_Stream_PlusOneAsUInt64_Fail()
		{
			using ( var buffer = new MemoryStream( new byte[] { 0xCF, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x01 } ) )
			{
				var result = Unpacking.UnpackByte( buffer );
				Assert.AreEqual( 9, buffer.Position );
				Assert.AreEqual( 1L, result );
			}
		}
		
		[Test]
		public void TestUnpackByte_ByteArray_PlusOneAsInt32_Fail()
		{
			var result = Unpacking.UnpackByte( new byte[] { 0xD2, 0x00, 0x00, 0x00, 0x01 } );
			Assert.AreEqual( 5, result.ReadCount );
			Assert.AreEqual( 1L, result.Value );
		}
		
		[Test]
		public void TestUnpackByte_Stream_PlusOneAsInt32_Fail()
		{
			using ( var buffer = new MemoryStream( new byte[] { 0xD2, 0x00, 0x00, 0x00, 0x01 } ) )
			{
				var result = Unpacking.UnpackByte( buffer );
				Assert.AreEqual( 5, buffer.Position );
				Assert.AreEqual( 1L, result );
			}
		}
		
		[Test]
		public void TestUnpackByte_ByteArray_PlusOneAsUInt32_Fail()
		{
			var result = Unpacking.UnpackByte( new byte[] { 0xCE, 0x00, 0x00, 0x00, 0x01 } );
			Assert.AreEqual( 5, result.ReadCount );
			Assert.AreEqual( 1L, result.Value );
		}
		
		[Test]
		public void TestUnpackByte_Stream_PlusOneAsUInt32_Fail()
		{
			using ( var buffer = new MemoryStream( new byte[] { 0xCE, 0x00, 0x00, 0x00, 0x01 } ) )
			{
				var result = Unpacking.UnpackByte( buffer );
				Assert.AreEqual( 5, buffer.Position );
				Assert.AreEqual( 1L, result );
			}
		}
		
		[Test]
		public void TestUnpackByte_ByteArray_PlusOneAsInt16_Fail()
		{
			var result = Unpacking.UnpackByte( new byte[] { 0xD1, 0x00, 0x01 } );
			Assert.AreEqual( 3, result.ReadCount );
			Assert.AreEqual( 1L, result.Value );
		}
		
		[Test]
		public void TestUnpackByte_Stream_PlusOneAsInt16_Fail()
		{
			using ( var buffer = new MemoryStream( new byte[] { 0xD1, 0x00, 0x01 } ) )
			{
				var result = Unpacking.UnpackByte( buffer );
				Assert.AreEqual( 3, buffer.Position );
				Assert.AreEqual( 1L, result );
			}
		}
		
		[Test]
		public void TestUnpackByte_ByteArray_PlusOneAsUInt16_Fail()
		{
			var result = Unpacking.UnpackByte( new byte[] { 0xCD, 0x00, 0x01 } );
			Assert.AreEqual( 3, result.ReadCount );
			Assert.AreEqual( 1L, result.Value );
		}
		
		[Test]
		public void TestUnpackByte_Stream_PlusOneAsUInt16_Fail()
		{
			using ( var buffer = new MemoryStream( new byte[] { 0xCD, 0x00, 0x01 } ) )
			{
				var result = Unpacking.UnpackByte( buffer );
				Assert.AreEqual( 3, buffer.Position );
				Assert.AreEqual( 1L, result );
			}
		}
		
		[Test]
		public void TestUnpackByte_ByteArray_PlusOneAsInt8_Fail()
		{
			var result = Unpacking.UnpackByte( new byte[] { 0xD0, 0x01 } );
			Assert.AreEqual( 2, result.ReadCount );
			Assert.AreEqual( 1L, result.Value );
		}
		
		[Test]
		public void TestUnpackByte_Stream_PlusOneAsInt8_Fail()
		{
			using ( var buffer = new MemoryStream( new byte[] { 0xD0, 0x01 } ) )
			{
				var result = Unpacking.UnpackByte( buffer );
				Assert.AreEqual( 2, buffer.Position );
				Assert.AreEqual( 1L, result );
			}
		}
		
		[Test]
		public void TestUnpackByte_ByteArray_PlusOneAsUInt8_Fail()
		{
			var result = Unpacking.UnpackByte( new byte[] { 0xCC, 0x01 } );
			Assert.AreEqual( 2, result.ReadCount );
			Assert.AreEqual( 1L, result.Value );
		}
		
		[Test]
		public void TestUnpackByte_Stream_PlusOneAsUInt8_Fail()
		{
			using ( var buffer = new MemoryStream( new byte[] { 0xCC, 0x01 } ) )
			{
				var result = Unpacking.UnpackByte( buffer );
				Assert.AreEqual( 2, buffer.Position );
				Assert.AreEqual( 1L, result );
			}
		}
		
		[Test]
		public void TestUnpackByte_ByteArray_PlusOneAsPositiveFixNum1_Fail()
		{
			var result = Unpacking.UnpackByte( new byte[] { 0x01 } );
			Assert.AreEqual( 1, result.ReadCount );
			Assert.AreEqual( 1L, result.Value );
		}
		
		[Test]
		public void TestUnpackByte_Stream_PlusOneAsPositiveFixNum1_Fail()
		{
			using ( var buffer = new MemoryStream( new byte[] { 0x01 } ) )
			{
				var result = Unpacking.UnpackByte( buffer );
				Assert.AreEqual( 1, buffer.Position );
				Assert.AreEqual( 1L, result );
			}
		}
		
		[Test]
		public void TestUnpackByte_ByteArray_PositiveFixNumMaxValueAsInt64_Fail()
		{
			var result = Unpacking.UnpackByte( new byte[] { 0xD3, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x7F } );
			Assert.AreEqual( 9, result.ReadCount );
			Assert.AreEqual( 127L, result.Value );
		}
		
		[Test]
		public void TestUnpackByte_Stream_PositiveFixNumMaxValueAsInt64_Fail()
		{
			using ( var buffer = new MemoryStream( new byte[] { 0xD3, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x7F } ) )
			{
				var result = Unpacking.UnpackByte( buffer );
				Assert.AreEqual( 9, buffer.Position );
				Assert.AreEqual( 127L, result );
			}
		}
		
		[Test]
		public void TestUnpackByte_ByteArray_PositiveFixNumMaxValueAsUInt64_Fail()
		{
			var result = Unpacking.UnpackByte( new byte[] { 0xCF, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x7F } );
			Assert.AreEqual( 9, result.ReadCount );
			Assert.AreEqual( 127L, result.Value );
		}
		
		[Test]
		public void TestUnpackByte_Stream_PositiveFixNumMaxValueAsUInt64_Fail()
		{
			using ( var buffer = new MemoryStream( new byte[] { 0xCF, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x7F } ) )
			{
				var result = Unpacking.UnpackByte( buffer );
				Assert.AreEqual( 9, buffer.Position );
				Assert.AreEqual( 127L, result );
			}
		}
		
		[Test]
		public void TestUnpackByte_ByteArray_PositiveFixNumMaxValueAsInt32_Fail()
		{
			var result = Unpacking.UnpackByte( new byte[] { 0xD2, 0x00, 0x00, 0x00, 0x7F } );
			Assert.AreEqual( 5, result.ReadCount );
			Assert.AreEqual( 127L, result.Value );
		}
		
		[Test]
		public void TestUnpackByte_Stream_PositiveFixNumMaxValueAsInt32_Fail()
		{
			using ( var buffer = new MemoryStream( new byte[] { 0xD2, 0x00, 0x00, 0x00, 0x7F } ) )
			{
				var result = Unpacking.UnpackByte( buffer );
				Assert.AreEqual( 5, buffer.Position );
				Assert.AreEqual( 127L, result );
			}
		}
		
		[Test]
		public void TestUnpackByte_ByteArray_PositiveFixNumMaxValueAsUInt32_Fail()
		{
			var result = Unpacking.UnpackByte( new byte[] { 0xCE, 0x00, 0x00, 0x00, 0x7F } );
			Assert.AreEqual( 5, result.ReadCount );
			Assert.AreEqual( 127L, result.Value );
		}
		
		[Test]
		public void TestUnpackByte_Stream_PositiveFixNumMaxValueAsUInt32_Fail()
		{
			using ( var buffer = new MemoryStream( new byte[] { 0xCE, 0x00, 0x00, 0x00, 0x7F } ) )
			{
				var result = Unpacking.UnpackByte( buffer );
				Assert.AreEqual( 5, buffer.Position );
				Assert.AreEqual( 127L, result );
			}
		}
		
		[Test]
		public void TestUnpackByte_ByteArray_PositiveFixNumMaxValueAsInt16_Fail()
		{
			var result = Unpacking.UnpackByte( new byte[] { 0xD1, 0x00, 0x7F } );
			Assert.AreEqual( 3, result.ReadCount );
			Assert.AreEqual( 127L, result.Value );
		}
		
		[Test]
		public void TestUnpackByte_Stream_PositiveFixNumMaxValueAsInt16_Fail()
		{
			using ( var buffer = new MemoryStream( new byte[] { 0xD1, 0x00, 0x7F } ) )
			{
				var result = Unpacking.UnpackByte( buffer );
				Assert.AreEqual( 3, buffer.Position );
				Assert.AreEqual( 127L, result );
			}
		}
		
		[Test]
		public void TestUnpackByte_ByteArray_PositiveFixNumMaxValueAsUInt16_Fail()
		{
			var result = Unpacking.UnpackByte( new byte[] { 0xCD, 0x00, 0x7F } );
			Assert.AreEqual( 3, result.ReadCount );
			Assert.AreEqual( 127L, result.Value );
		}
		
		[Test]
		public void TestUnpackByte_Stream_PositiveFixNumMaxValueAsUInt16_Fail()
		{
			using ( var buffer = new MemoryStream( new byte[] { 0xCD, 0x00, 0x7F } ) )
			{
				var result = Unpacking.UnpackByte( buffer );
				Assert.AreEqual( 3, buffer.Position );
				Assert.AreEqual( 127L, result );
			}
		}
		
		[Test]
		public void TestUnpackByte_ByteArray_PositiveFixNumMaxValueAsInt8_Fail()
		{
			var result = Unpacking.UnpackByte( new byte[] { 0xD0, 0x7F } );
			Assert.AreEqual( 2, result.ReadCount );
			Assert.AreEqual( 127L, result.Value );
		}
		
		[Test]
		public void TestUnpackByte_Stream_PositiveFixNumMaxValueAsInt8_Fail()
		{
			using ( var buffer = new MemoryStream( new byte[] { 0xD0, 0x7F } ) )
			{
				var result = Unpacking.UnpackByte( buffer );
				Assert.AreEqual( 2, buffer.Position );
				Assert.AreEqual( 127L, result );
			}
		}
		
		[Test]
		public void TestUnpackByte_ByteArray_PositiveFixNumMaxValueAsUInt8_Fail()
		{
			var result = Unpacking.UnpackByte( new byte[] { 0xCC, 0x7F } );
			Assert.AreEqual( 2, result.ReadCount );
			Assert.AreEqual( 127L, result.Value );
		}
		
		[Test]
		public void TestUnpackByte_Stream_PositiveFixNumMaxValueAsUInt8_Fail()
		{
			using ( var buffer = new MemoryStream( new byte[] { 0xCC, 0x7F } ) )
			{
				var result = Unpacking.UnpackByte( buffer );
				Assert.AreEqual( 2, buffer.Position );
				Assert.AreEqual( 127L, result );
			}
		}
		
		[Test]
		public void TestUnpackByte_ByteArray_PositiveFixNumMaxValueAsPositiveFixNum127_Fail()
		{
			var result = Unpacking.UnpackByte( new byte[] { 0x7F } );
			Assert.AreEqual( 1, result.ReadCount );
			Assert.AreEqual( 127L, result.Value );
		}
		
		[Test]
		public void TestUnpackByte_Stream_PositiveFixNumMaxValueAsPositiveFixNum127_Fail()
		{
			using ( var buffer = new MemoryStream( new byte[] { 0x7F } ) )
			{
				var result = Unpacking.UnpackByte( buffer );
				Assert.AreEqual( 1, buffer.Position );
				Assert.AreEqual( 127L, result );
			}
		}
		
		[Test]
		public void TestUnpackByte_ByteArray_PositiveFixNumMaxValuePlusOneAsInt64_Fail()
		{
			var result = Unpacking.UnpackByte( new byte[] { 0xD3, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x80 } );
			Assert.AreEqual( 9, result.ReadCount );
			Assert.AreEqual( 128L, result.Value );
		}
		
		[Test]
		public void TestUnpackByte_Stream_PositiveFixNumMaxValuePlusOneAsInt64_Fail()
		{
			using ( var buffer = new MemoryStream( new byte[] { 0xD3, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x80 } ) )
			{
				var result = Unpacking.UnpackByte( buffer );
				Assert.AreEqual( 9, buffer.Position );
				Assert.AreEqual( 128L, result );
			}
		}
		
		[Test]
		public void TestUnpackByte_ByteArray_PositiveFixNumMaxValuePlusOneAsUInt64_Fail()
		{
			var result = Unpacking.UnpackByte( new byte[] { 0xCF, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x80 } );
			Assert.AreEqual( 9, result.ReadCount );
			Assert.AreEqual( 128L, result.Value );
		}
		
		[Test]
		public void TestUnpackByte_Stream_PositiveFixNumMaxValuePlusOneAsUInt64_Fail()
		{
			using ( var buffer = new MemoryStream( new byte[] { 0xCF, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x80 } ) )
			{
				var result = Unpacking.UnpackByte( buffer );
				Assert.AreEqual( 9, buffer.Position );
				Assert.AreEqual( 128L, result );
			}
		}
		
		[Test]
		public void TestUnpackByte_ByteArray_PositiveFixNumMaxValuePlusOneAsInt32_Fail()
		{
			var result = Unpacking.UnpackByte( new byte[] { 0xD2, 0x00, 0x00, 0x00, 0x80 } );
			Assert.AreEqual( 5, result.ReadCount );
			Assert.AreEqual( 128L, result.Value );
		}
		
		[Test]
		public void TestUnpackByte_Stream_PositiveFixNumMaxValuePlusOneAsInt32_Fail()
		{
			using ( var buffer = new MemoryStream( new byte[] { 0xD2, 0x00, 0x00, 0x00, 0x80 } ) )
			{
				var result = Unpacking.UnpackByte( buffer );
				Assert.AreEqual( 5, buffer.Position );
				Assert.AreEqual( 128L, result );
			}
		}
		
		[Test]
		public void TestUnpackByte_ByteArray_PositiveFixNumMaxValuePlusOneAsUInt32_Fail()
		{
			var result = Unpacking.UnpackByte( new byte[] { 0xCE, 0x00, 0x00, 0x00, 0x80 } );
			Assert.AreEqual( 5, result.ReadCount );
			Assert.AreEqual( 128L, result.Value );
		}
		
		[Test]
		public void TestUnpackByte_Stream_PositiveFixNumMaxValuePlusOneAsUInt32_Fail()
		{
			using ( var buffer = new MemoryStream( new byte[] { 0xCE, 0x00, 0x00, 0x00, 0x80 } ) )
			{
				var result = Unpacking.UnpackByte( buffer );
				Assert.AreEqual( 5, buffer.Position );
				Assert.AreEqual( 128L, result );
			}
		}
		
		[Test]
		public void TestUnpackByte_ByteArray_PositiveFixNumMaxValuePlusOneAsInt16_Fail()
		{
			var result = Unpacking.UnpackByte( new byte[] { 0xD1, 0x00, 0x80 } );
			Assert.AreEqual( 3, result.ReadCount );
			Assert.AreEqual( 128L, result.Value );
		}
		
		[Test]
		public void TestUnpackByte_Stream_PositiveFixNumMaxValuePlusOneAsInt16_Fail()
		{
			using ( var buffer = new MemoryStream( new byte[] { 0xD1, 0x00, 0x80 } ) )
			{
				var result = Unpacking.UnpackByte( buffer );
				Assert.AreEqual( 3, buffer.Position );
				Assert.AreEqual( 128L, result );
			}
		}
		
		[Test]
		public void TestUnpackByte_ByteArray_PositiveFixNumMaxValuePlusOneAsUInt16_Fail()
		{
			var result = Unpacking.UnpackByte( new byte[] { 0xCD, 0x00, 0x80 } );
			Assert.AreEqual( 3, result.ReadCount );
			Assert.AreEqual( 128L, result.Value );
		}
		
		[Test]
		public void TestUnpackByte_Stream_PositiveFixNumMaxValuePlusOneAsUInt16_Fail()
		{
			using ( var buffer = new MemoryStream( new byte[] { 0xCD, 0x00, 0x80 } ) )
			{
				var result = Unpacking.UnpackByte( buffer );
				Assert.AreEqual( 3, buffer.Position );
				Assert.AreEqual( 128L, result );
			}
		}
		
		[Test]
		public void TestUnpackByte_ByteArray_PositiveFixNumMaxValuePlusOneAsUInt8_Fail()
		{
			var result = Unpacking.UnpackByte( new byte[] { 0xCC, 0x80 } );
			Assert.AreEqual( 2, result.ReadCount );
			Assert.AreEqual( 128L, result.Value );
		}
		
		[Test]
		public void TestUnpackByte_Stream_PositiveFixNumMaxValuePlusOneAsUInt8_Fail()
		{
			using ( var buffer = new MemoryStream( new byte[] { 0xCC, 0x80 } ) )
			{
				var result = Unpacking.UnpackByte( buffer );
				Assert.AreEqual( 2, buffer.Position );
				Assert.AreEqual( 128L, result );
			}
		}
		
		[Test]
		public void TestUnpackByte_ByteArray_ByteMaxValueAsInt64_Fail()
		{
			var result = Unpacking.UnpackByte( new byte[] { 0xD3, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0xFF } );
			Assert.AreEqual( 9, result.ReadCount );
			Assert.AreEqual( 255L, result.Value );
		}
		
		[Test]
		public void TestUnpackByte_Stream_ByteMaxValueAsInt64_Fail()
		{
			using ( var buffer = new MemoryStream( new byte[] { 0xD3, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0xFF } ) )
			{
				var result = Unpacking.UnpackByte( buffer );
				Assert.AreEqual( 9, buffer.Position );
				Assert.AreEqual( 255L, result );
			}
		}
		
		[Test]
		public void TestUnpackByte_ByteArray_ByteMaxValueAsUInt64_Fail()
		{
			var result = Unpacking.UnpackByte( new byte[] { 0xCF, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0xFF } );
			Assert.AreEqual( 9, result.ReadCount );
			Assert.AreEqual( 255L, result.Value );
		}
		
		[Test]
		public void TestUnpackByte_Stream_ByteMaxValueAsUInt64_Fail()
		{
			using ( var buffer = new MemoryStream( new byte[] { 0xCF, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0xFF } ) )
			{
				var result = Unpacking.UnpackByte( buffer );
				Assert.AreEqual( 9, buffer.Position );
				Assert.AreEqual( 255L, result );
			}
		}
		
		[Test]
		public void TestUnpackByte_ByteArray_ByteMaxValueAsInt32_Fail()
		{
			var result = Unpacking.UnpackByte( new byte[] { 0xD2, 0x00, 0x00, 0x00, 0xFF } );
			Assert.AreEqual( 5, result.ReadCount );
			Assert.AreEqual( 255L, result.Value );
		}
		
		[Test]
		public void TestUnpackByte_Stream_ByteMaxValueAsInt32_Fail()
		{
			using ( var buffer = new MemoryStream( new byte[] { 0xD2, 0x00, 0x00, 0x00, 0xFF } ) )
			{
				var result = Unpacking.UnpackByte( buffer );
				Assert.AreEqual( 5, buffer.Position );
				Assert.AreEqual( 255L, result );
			}
		}
		
		[Test]
		public void TestUnpackByte_ByteArray_ByteMaxValueAsUInt32_Fail()
		{
			var result = Unpacking.UnpackByte( new byte[] { 0xCE, 0x00, 0x00, 0x00, 0xFF } );
			Assert.AreEqual( 5, result.ReadCount );
			Assert.AreEqual( 255L, result.Value );
		}
		
		[Test]
		public void TestUnpackByte_Stream_ByteMaxValueAsUInt32_Fail()
		{
			using ( var buffer = new MemoryStream( new byte[] { 0xCE, 0x00, 0x00, 0x00, 0xFF } ) )
			{
				var result = Unpacking.UnpackByte( buffer );
				Assert.AreEqual( 5, buffer.Position );
				Assert.AreEqual( 255L, result );
			}
		}
		
		[Test]
		public void TestUnpackByte_ByteArray_ByteMaxValueAsInt16_Fail()
		{
			var result = Unpacking.UnpackByte( new byte[] { 0xD1, 0x00, 0xFF } );
			Assert.AreEqual( 3, result.ReadCount );
			Assert.AreEqual( 255L, result.Value );
		}
		
		[Test]
		public void TestUnpackByte_Stream_ByteMaxValueAsInt16_Fail()
		{
			using ( var buffer = new MemoryStream( new byte[] { 0xD1, 0x00, 0xFF } ) )
			{
				var result = Unpacking.UnpackByte( buffer );
				Assert.AreEqual( 3, buffer.Position );
				Assert.AreEqual( 255L, result );
			}
		}
		
		[Test]
		public void TestUnpackByte_ByteArray_ByteMaxValueAsUInt16_Fail()
		{
			var result = Unpacking.UnpackByte( new byte[] { 0xCD, 0x00, 0xFF } );
			Assert.AreEqual( 3, result.ReadCount );
			Assert.AreEqual( 255L, result.Value );
		}
		
		[Test]
		public void TestUnpackByte_Stream_ByteMaxValueAsUInt16_Fail()
		{
			using ( var buffer = new MemoryStream( new byte[] { 0xCD, 0x00, 0xFF } ) )
			{
				var result = Unpacking.UnpackByte( buffer );
				Assert.AreEqual( 3, buffer.Position );
				Assert.AreEqual( 255L, result );
			}
		}
		
		[Test]
		public void TestUnpackByte_ByteArray_ByteMaxValueAsUInt8_Fail()
		{
			var result = Unpacking.UnpackByte( new byte[] { 0xCC, 0xFF } );
			Assert.AreEqual( 2, result.ReadCount );
			Assert.AreEqual( 255L, result.Value );
		}
		
		[Test]
		public void TestUnpackByte_Stream_ByteMaxValueAsUInt8_Fail()
		{
			using ( var buffer = new MemoryStream( new byte[] { 0xCC, 0xFF } ) )
			{
				var result = Unpacking.UnpackByte( buffer );
				Assert.AreEqual( 2, buffer.Position );
				Assert.AreEqual( 255L, result );
			}
		}
		
		[Test]
		[ExpectedException( typeof( MessageTypeException ) )]
		public void TestUnpackByte_ByteArray_ByteMaxValuePlusOneAsInt64_AsIs()
		{
			var result = Unpacking.UnpackByte( new byte[] { 0xD3, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x01, 0x00 } );
		}
		
		[Test]
		[ExpectedException( typeof( MessageTypeException ) )]
		public void TestUnpackByte_Stream_ByteMaxValuePlusOneAsInt64_AsIs()
		{
			using ( var buffer = new MemoryStream( new byte[] { 0xD3, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x01, 0x00 } ) )
			{
				var result = Unpacking.UnpackByte( buffer );
			}
		}
		
		[Test]
		[ExpectedException( typeof( MessageTypeException ) )]
		public void TestUnpackByte_ByteArray_ByteMaxValuePlusOneAsUInt64_AsIs()
		{
			var result = Unpacking.UnpackByte( new byte[] { 0xCF, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x01, 0x00 } );
		}
		
		[Test]
		[ExpectedException( typeof( MessageTypeException ) )]
		public void TestUnpackByte_Stream_ByteMaxValuePlusOneAsUInt64_AsIs()
		{
			using ( var buffer = new MemoryStream( new byte[] { 0xCF, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x01, 0x00 } ) )
			{
				var result = Unpacking.UnpackByte( buffer );
			}
		}
		
		[Test]
		[ExpectedException( typeof( MessageTypeException ) )]
		public void TestUnpackByte_ByteArray_ByteMaxValuePlusOneAsInt32_AsIs()
		{
			var result = Unpacking.UnpackByte( new byte[] { 0xD2, 0x00, 0x00, 0x01, 0x00 } );
		}
		
		[Test]
		[ExpectedException( typeof( MessageTypeException ) )]
		public void TestUnpackByte_Stream_ByteMaxValuePlusOneAsInt32_AsIs()
		{
			using ( var buffer = new MemoryStream( new byte[] { 0xD2, 0x00, 0x00, 0x01, 0x00 } ) )
			{
				var result = Unpacking.UnpackByte( buffer );
			}
		}
		
		[Test]
		[ExpectedException( typeof( MessageTypeException ) )]
		public void TestUnpackByte_ByteArray_ByteMaxValuePlusOneAsUInt32_AsIs()
		{
			var result = Unpacking.UnpackByte( new byte[] { 0xCE, 0x00, 0x00, 0x01, 0x00 } );
		}
		
		[Test]
		[ExpectedException( typeof( MessageTypeException ) )]
		public void TestUnpackByte_Stream_ByteMaxValuePlusOneAsUInt32_AsIs()
		{
			using ( var buffer = new MemoryStream( new byte[] { 0xCE, 0x00, 0x00, 0x01, 0x00 } ) )
			{
				var result = Unpacking.UnpackByte( buffer );
			}
		}
		
		[Test]
		[ExpectedException( typeof( MessageTypeException ) )]
		public void TestUnpackByte_ByteArray_ByteMaxValuePlusOneAsInt16_AsIs()
		{
			var result = Unpacking.UnpackByte( new byte[] { 0xD1, 0x01, 0x00 } );
		}
		
		[Test]
		[ExpectedException( typeof( MessageTypeException ) )]
		public void TestUnpackByte_Stream_ByteMaxValuePlusOneAsInt16_AsIs()
		{
			using ( var buffer = new MemoryStream( new byte[] { 0xD1, 0x01, 0x00 } ) )
			{
				var result = Unpacking.UnpackByte( buffer );
			}
		}
		
		[Test]
		[ExpectedException( typeof( MessageTypeException ) )]
		public void TestUnpackByte_ByteArray_ByteMaxValuePlusOneAsUInt16_AsIs()
		{
			var result = Unpacking.UnpackByte( new byte[] { 0xCD, 0x01, 0x00 } );
		}
		
		[Test]
		[ExpectedException( typeof( MessageTypeException ) )]
		public void TestUnpackByte_Stream_ByteMaxValuePlusOneAsUInt16_AsIs()
		{
			using ( var buffer = new MemoryStream( new byte[] { 0xCD, 0x01, 0x00 } ) )
			{
				var result = Unpacking.UnpackByte( buffer );
			}
		}
		
		[Test]
		[ExpectedException( typeof( MessageTypeException ) )]
		public void TestUnpackByte_ByteArray_UInt16MaxValueAsInt64_AsIs()
		{
			var result = Unpacking.UnpackByte( new byte[] { 0xD3, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0xFF, 0xFF } );
		}
		
		[Test]
		[ExpectedException( typeof( MessageTypeException ) )]
		public void TestUnpackByte_Stream_UInt16MaxValueAsInt64_AsIs()
		{
			using ( var buffer = new MemoryStream( new byte[] { 0xD3, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0xFF, 0xFF } ) )
			{
				var result = Unpacking.UnpackByte( buffer );
			}
		}
		
		[Test]
		[ExpectedException( typeof( MessageTypeException ) )]
		public void TestUnpackByte_ByteArray_UInt16MaxValueAsUInt64_AsIs()
		{
			var result = Unpacking.UnpackByte( new byte[] { 0xCF, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0xFF, 0xFF } );
		}
		
		[Test]
		[ExpectedException( typeof( MessageTypeException ) )]
		public void TestUnpackByte_Stream_UInt16MaxValueAsUInt64_AsIs()
		{
			using ( var buffer = new MemoryStream( new byte[] { 0xCF, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0xFF, 0xFF } ) )
			{
				var result = Unpacking.UnpackByte( buffer );
			}
		}
		
		[Test]
		[ExpectedException( typeof( MessageTypeException ) )]
		public void TestUnpackByte_ByteArray_UInt16MaxValueAsInt32_AsIs()
		{
			var result = Unpacking.UnpackByte( new byte[] { 0xD2, 0x00, 0x00, 0xFF, 0xFF } );
		}
		
		[Test]
		[ExpectedException( typeof( MessageTypeException ) )]
		public void TestUnpackByte_Stream_UInt16MaxValueAsInt32_AsIs()
		{
			using ( var buffer = new MemoryStream( new byte[] { 0xD2, 0x00, 0x00, 0xFF, 0xFF } ) )
			{
				var result = Unpacking.UnpackByte( buffer );
			}
		}
		
		[Test]
		[ExpectedException( typeof( MessageTypeException ) )]
		public void TestUnpackByte_ByteArray_UInt16MaxValueAsUInt32_AsIs()
		{
			var result = Unpacking.UnpackByte( new byte[] { 0xCE, 0x00, 0x00, 0xFF, 0xFF } );
		}
		
		[Test]
		[ExpectedException( typeof( MessageTypeException ) )]
		public void TestUnpackByte_Stream_UInt16MaxValueAsUInt32_AsIs()
		{
			using ( var buffer = new MemoryStream( new byte[] { 0xCE, 0x00, 0x00, 0xFF, 0xFF } ) )
			{
				var result = Unpacking.UnpackByte( buffer );
			}
		}
		
		[Test]
		[ExpectedException( typeof( MessageTypeException ) )]
		public void TestUnpackByte_ByteArray_UInt16MaxValueAsUInt16_AsIs()
		{
			var result = Unpacking.UnpackByte( new byte[] { 0xCD, 0xFF, 0xFF } );
		}
		
		[Test]
		[ExpectedException( typeof( MessageTypeException ) )]
		public void TestUnpackByte_Stream_UInt16MaxValueAsUInt16_AsIs()
		{
			using ( var buffer = new MemoryStream( new byte[] { 0xCD, 0xFF, 0xFF } ) )
			{
				var result = Unpacking.UnpackByte( buffer );
			}
		}
		
		[Test]
		[ExpectedException( typeof( MessageTypeException ) )]
		public void TestUnpackByte_ByteArray_UInt16MaxValuePlusOneAsInt64_AsIs()
		{
			var result = Unpacking.UnpackByte( new byte[] { 0xD3, 0x00, 0x00, 0x00, 0x00, 0x00, 0x01, 0x00, 0x00 } );
		}
		
		[Test]
		[ExpectedException( typeof( MessageTypeException ) )]
		public void TestUnpackByte_Stream_UInt16MaxValuePlusOneAsInt64_AsIs()
		{
			using ( var buffer = new MemoryStream( new byte[] { 0xD3, 0x00, 0x00, 0x00, 0x00, 0x00, 0x01, 0x00, 0x00 } ) )
			{
				var result = Unpacking.UnpackByte( buffer );
			}
		}
		
		[Test]
		[ExpectedException( typeof( MessageTypeException ) )]
		public void TestUnpackByte_ByteArray_UInt16MaxValuePlusOneAsUInt64_AsIs()
		{
			var result = Unpacking.UnpackByte( new byte[] { 0xCF, 0x00, 0x00, 0x00, 0x00, 0x00, 0x01, 0x00, 0x00 } );
		}
		
		[Test]
		[ExpectedException( typeof( MessageTypeException ) )]
		public void TestUnpackByte_Stream_UInt16MaxValuePlusOneAsUInt64_AsIs()
		{
			using ( var buffer = new MemoryStream( new byte[] { 0xCF, 0x00, 0x00, 0x00, 0x00, 0x00, 0x01, 0x00, 0x00 } ) )
			{
				var result = Unpacking.UnpackByte( buffer );
			}
		}
		
		[Test]
		[ExpectedException( typeof( MessageTypeException ) )]
		public void TestUnpackByte_ByteArray_UInt16MaxValuePlusOneAsInt32_AsIs()
		{
			var result = Unpacking.UnpackByte( new byte[] { 0xD2, 0x00, 0x01, 0x00, 0x00 } );
		}
		
		[Test]
		[ExpectedException( typeof( MessageTypeException ) )]
		public void TestUnpackByte_Stream_UInt16MaxValuePlusOneAsInt32_AsIs()
		{
			using ( var buffer = new MemoryStream( new byte[] { 0xD2, 0x00, 0x01, 0x00, 0x00 } ) )
			{
				var result = Unpacking.UnpackByte( buffer );
			}
		}
		
		[Test]
		[ExpectedException( typeof( MessageTypeException ) )]
		public void TestUnpackByte_ByteArray_UInt16MaxValuePlusOneAsUInt32_AsIs()
		{
			var result = Unpacking.UnpackByte( new byte[] { 0xCE, 0x00, 0x01, 0x00, 0x00 } );
		}
		
		[Test]
		[ExpectedException( typeof( MessageTypeException ) )]
		public void TestUnpackByte_Stream_UInt16MaxValuePlusOneAsUInt32_AsIs()
		{
			using ( var buffer = new MemoryStream( new byte[] { 0xCE, 0x00, 0x01, 0x00, 0x00 } ) )
			{
				var result = Unpacking.UnpackByte( buffer );
			}
		}
		
		[Test]
		[ExpectedException( typeof( MessageTypeException ) )]
		public void TestUnpackByte_ByteArray_UInt32MaxValueAsInt64_AsIs()
		{
			var result = Unpacking.UnpackByte( new byte[] { 0xD3, 0x00, 0x00, 0x00, 0x00, 0xFF, 0xFF, 0xFF, 0xFF } );
		}
		
		[Test]
		[ExpectedException( typeof( MessageTypeException ) )]
		public void TestUnpackByte_Stream_UInt32MaxValueAsInt64_AsIs()
		{
			using ( var buffer = new MemoryStream( new byte[] { 0xD3, 0x00, 0x00, 0x00, 0x00, 0xFF, 0xFF, 0xFF, 0xFF } ) )
			{
				var result = Unpacking.UnpackByte( buffer );
			}
		}
		
		[Test]
		[ExpectedException( typeof( MessageTypeException ) )]
		public void TestUnpackByte_ByteArray_UInt32MaxValueAsUInt64_AsIs()
		{
			var result = Unpacking.UnpackByte( new byte[] { 0xCF, 0x00, 0x00, 0x00, 0x00, 0xFF, 0xFF, 0xFF, 0xFF } );
		}
		
		[Test]
		[ExpectedException( typeof( MessageTypeException ) )]
		public void TestUnpackByte_Stream_UInt32MaxValueAsUInt64_AsIs()
		{
			using ( var buffer = new MemoryStream( new byte[] { 0xCF, 0x00, 0x00, 0x00, 0x00, 0xFF, 0xFF, 0xFF, 0xFF } ) )
			{
				var result = Unpacking.UnpackByte( buffer );
			}
		}
		
		[Test]
		[ExpectedException( typeof( MessageTypeException ) )]
		public void TestUnpackByte_ByteArray_UInt32MaxValueAsUInt32_AsIs()
		{
			var result = Unpacking.UnpackByte( new byte[] { 0xCE, 0xFF, 0xFF, 0xFF, 0xFF } );
		}
		
		[Test]
		[ExpectedException( typeof( MessageTypeException ) )]
		public void TestUnpackByte_Stream_UInt32MaxValueAsUInt32_AsIs()
		{
			using ( var buffer = new MemoryStream( new byte[] { 0xCE, 0xFF, 0xFF, 0xFF, 0xFF } ) )
			{
				var result = Unpacking.UnpackByte( buffer );
			}
		}
		
		[Test]
		[ExpectedException( typeof( MessageTypeException ) )]
		public void TestUnpackByte_ByteArray_UInt32MaxValuePlusOneAsInt64_AsIs()
		{
			var result = Unpacking.UnpackByte( new byte[] { 0xD3, 0x00, 0x00, 0x00, 0x01, 0x00, 0x00, 0x00, 0x00 } );
		}
		
		[Test]
		[ExpectedException( typeof( MessageTypeException ) )]
		public void TestUnpackByte_Stream_UInt32MaxValuePlusOneAsInt64_AsIs()
		{
			using ( var buffer = new MemoryStream( new byte[] { 0xD3, 0x00, 0x00, 0x00, 0x01, 0x00, 0x00, 0x00, 0x00 } ) )
			{
				var result = Unpacking.UnpackByte( buffer );
			}
		}
		
		[Test]
		[ExpectedException( typeof( MessageTypeException ) )]
		public void TestUnpackByte_ByteArray_UInt32MaxValuePlusOneAsUInt64_AsIs()
		{
			var result = Unpacking.UnpackByte( new byte[] { 0xCF, 0x00, 0x00, 0x00, 0x01, 0x00, 0x00, 0x00, 0x00 } );
		}
		
		[Test]
		[ExpectedException( typeof( MessageTypeException ) )]
		public void TestUnpackByte_Stream_UInt32MaxValuePlusOneAsUInt64_AsIs()
		{
			using ( var buffer = new MemoryStream( new byte[] { 0xCF, 0x00, 0x00, 0x00, 0x01, 0x00, 0x00, 0x00, 0x00 } ) )
			{
				var result = Unpacking.UnpackByte( buffer );
			}
		}
		
		[Test]
		[ExpectedException( typeof( MessageTypeException ) )]
		public void TestUnpackByte_ByteArray_UInt64MaxValueAsUInt64_AsIs()
		{
			var result = Unpacking.UnpackByte( new byte[] { 0xCF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF } );
		}
		
		[Test]
		[ExpectedException( typeof( MessageTypeException ) )]
		public void TestUnpackByte_Stream_UInt64MaxValueAsUInt64_AsIs()
		{
			using ( var buffer = new MemoryStream( new byte[] { 0xCF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF } ) )
			{
				var result = Unpacking.UnpackByte( buffer );
			}
		}
		
		[Test]
		[ExpectedException( typeof( ArgumentException ) )]
		public void TestUnpackByte_ByteArray_Empty()
		{
			Unpacking.UnpackByte( new byte[ 0 ] );
		}

		[Test]
		[ExpectedException( typeof( ArgumentNullException ) )]
		public void TestUnpackByte_ByteArray_Null()
		{
			Unpacking.UnpackByte( default( byte[] ) );
		}

		[Test]
		[ExpectedException( typeof( ArgumentNullException ) )]
		public void TestUnpackByte_ByteArray_Offset_Null()
		{
			Unpacking.UnpackByte( default( byte[] ), 0 );
		}

		[Test]
		[ExpectedException( typeof( ArgumentOutOfRangeException ) )]
		public void TestUnpackByte_ByteArray_Offset_OffsetIsNegative()
		{
			Unpacking.UnpackByte( new byte[]{ 0x1 }, -1 );
		}

		[Test]
		[ExpectedException( typeof( ArgumentException ) )]
		public void TestUnpackByte_ByteArray_Offset_OffsetIsTooBig()
		{
			Unpacking.UnpackByte( new byte[]{ 0x1 }, 1 );
		}

		[Test]
		[ExpectedException( typeof( ArgumentException ) )]
		public void TestUnpackByte_ByteArray_Offset_Empty()
		{
			Unpacking.UnpackByte( new byte[ 0 ], 0 );
		}

		[Test]
		[ExpectedException( typeof( ArgumentNullException ) )]
		public void TestUnpackByte_Stream_Null()
		{
			Unpacking.UnpackByte( default( Stream ) );
		}

		[Test]
		public void TestUnpackByte_ByteArray_Offset_OffsetIsValid_OffsetIsRespected()
		{
			// Offset 1 is positive fix num 1.
			var result = Unpacking.UnpackByte( new byte[] { 0xFF, 0x57, 0xFF }, 1 );
			Assert.AreEqual( 1, result.ReadCount );
			Assert.AreEqual( 0x57, result.Value );
		}

		[Test]
		[ExpectedException( typeof( MessageTypeException ) )]
		public void TestUnpackByte_ByteArray_Null_Nil()
		{
			Unpacking.UnpackByte( new byte[] { 0xC0 } );
		}
	
		[Test]
		[ExpectedException( typeof( MessageTypeException ) )]
		public void TestUnpackByte_ByteArray_NotByte()
		{
			Unpacking.UnpackByte( new byte[] { 0xA0 } );
		}
	}

	partial class UnpackingTest_Combinations_Int16
	{
		[Test]
		[ExpectedException( typeof( MessageTypeException ) )]
		public void TestUnpackInt16_ByteArray_Int64MinValueAsInt64_AsIs()
		{
			var result = Unpacking.UnpackInt16( new byte[] { 0xD3, 0x80, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 } );
		}
		
		[Test]
		[ExpectedException( typeof( MessageTypeException ) )]
		public void TestUnpackInt16_Stream_Int64MinValueAsInt64_AsIs()
		{
			using ( var buffer = new MemoryStream( new byte[] { 0xD3, 0x80, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 } ) )
			{
				var result = Unpacking.UnpackInt16( buffer );
			}
		}
		
		[Test]
		[ExpectedException( typeof( MessageTypeException ) )]
		public void TestUnpackInt16_ByteArray_Int32MinValueMinusOneAsInt64_AsIs()
		{
			var result = Unpacking.UnpackInt16( new byte[] { 0xD3, 0xFF, 0xFF, 0xFF, 0xFF, 0x7F, 0xFF, 0xFF, 0xFF } );
		}
		
		[Test]
		[ExpectedException( typeof( MessageTypeException ) )]
		public void TestUnpackInt16_Stream_Int32MinValueMinusOneAsInt64_AsIs()
		{
			using ( var buffer = new MemoryStream( new byte[] { 0xD3, 0xFF, 0xFF, 0xFF, 0xFF, 0x7F, 0xFF, 0xFF, 0xFF } ) )
			{
				var result = Unpacking.UnpackInt16( buffer );
			}
		}
		
		[Test]
		[ExpectedException( typeof( MessageTypeException ) )]
		public void TestUnpackInt16_ByteArray_Int32MinValueAsInt64_AsIs()
		{
			var result = Unpacking.UnpackInt16( new byte[] { 0xD3, 0xFF, 0xFF, 0xFF, 0xFF, 0x80, 0x00, 0x00, 0x00 } );
		}
		
		[Test]
		[ExpectedException( typeof( MessageTypeException ) )]
		public void TestUnpackInt16_Stream_Int32MinValueAsInt64_AsIs()
		{
			using ( var buffer = new MemoryStream( new byte[] { 0xD3, 0xFF, 0xFF, 0xFF, 0xFF, 0x80, 0x00, 0x00, 0x00 } ) )
			{
				var result = Unpacking.UnpackInt16( buffer );
			}
		}
		
		[Test]
		[ExpectedException( typeof( MessageTypeException ) )]
		public void TestUnpackInt16_ByteArray_Int32MinValueAsInt32_AsIs()
		{
			var result = Unpacking.UnpackInt16( new byte[] { 0xD2, 0x80, 0x00, 0x00, 0x00 } );
		}
		
		[Test]
		[ExpectedException( typeof( MessageTypeException ) )]
		public void TestUnpackInt16_Stream_Int32MinValueAsInt32_AsIs()
		{
			using ( var buffer = new MemoryStream( new byte[] { 0xD2, 0x80, 0x00, 0x00, 0x00 } ) )
			{
				var result = Unpacking.UnpackInt16( buffer );
			}
		}
		
		[Test]
		[ExpectedException( typeof( MessageTypeException ) )]
		public void TestUnpackInt16_ByteArray_Int16MinValueMinusOneAsInt64_AsIs()
		{
			var result = Unpacking.UnpackInt16( new byte[] { 0xD3, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0x7F, 0xFF } );
		}
		
		[Test]
		[ExpectedException( typeof( MessageTypeException ) )]
		public void TestUnpackInt16_Stream_Int16MinValueMinusOneAsInt64_AsIs()
		{
			using ( var buffer = new MemoryStream( new byte[] { 0xD3, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0x7F, 0xFF } ) )
			{
				var result = Unpacking.UnpackInt16( buffer );
			}
		}
		
		[Test]
		[ExpectedException( typeof( MessageTypeException ) )]
		public void TestUnpackInt16_ByteArray_Int16MinValueMinusOneAsInt32_AsIs()
		{
			var result = Unpacking.UnpackInt16( new byte[] { 0xD2, 0xFF, 0xFF, 0x7F, 0xFF } );
		}
		
		[Test]
		[ExpectedException( typeof( MessageTypeException ) )]
		public void TestUnpackInt16_Stream_Int16MinValueMinusOneAsInt32_AsIs()
		{
			using ( var buffer = new MemoryStream( new byte[] { 0xD2, 0xFF, 0xFF, 0x7F, 0xFF } ) )
			{
				var result = Unpacking.UnpackInt16( buffer );
			}
		}
		
		[Test]
		public void TestUnpackInt16_ByteArray_Int16MinValueAsInt64_Fail()
		{
			var result = Unpacking.UnpackInt16( new byte[] { 0xD3, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0x80, 0x00 } );
			Assert.AreEqual( 9, result.ReadCount );
			Assert.AreEqual( -32768L, result.Value );
		}
		
		[Test]
		public void TestUnpackInt16_Stream_Int16MinValueAsInt64_Fail()
		{
			using ( var buffer = new MemoryStream( new byte[] { 0xD3, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0x80, 0x00 } ) )
			{
				var result = Unpacking.UnpackInt16( buffer );
				Assert.AreEqual( 9, buffer.Position );
				Assert.AreEqual( -32768L, result );
			}
		}
		
		[Test]
		public void TestUnpackInt16_ByteArray_Int16MinValueAsInt32_Fail()
		{
			var result = Unpacking.UnpackInt16( new byte[] { 0xD2, 0xFF, 0xFF, 0x80, 0x00 } );
			Assert.AreEqual( 5, result.ReadCount );
			Assert.AreEqual( -32768L, result.Value );
		}
		
		[Test]
		public void TestUnpackInt16_Stream_Int16MinValueAsInt32_Fail()
		{
			using ( var buffer = new MemoryStream( new byte[] { 0xD2, 0xFF, 0xFF, 0x80, 0x00 } ) )
			{
				var result = Unpacking.UnpackInt16( buffer );
				Assert.AreEqual( 5, buffer.Position );
				Assert.AreEqual( -32768L, result );
			}
		}
		
		[Test]
		public void TestUnpackInt16_ByteArray_Int16MinValueAsInt16_Fail()
		{
			var result = Unpacking.UnpackInt16( new byte[] { 0xD1, 0x80, 0x00 } );
			Assert.AreEqual( 3, result.ReadCount );
			Assert.AreEqual( -32768L, result.Value );
		}
		
		[Test]
		public void TestUnpackInt16_Stream_Int16MinValueAsInt16_Fail()
		{
			using ( var buffer = new MemoryStream( new byte[] { 0xD1, 0x80, 0x00 } ) )
			{
				var result = Unpacking.UnpackInt16( buffer );
				Assert.AreEqual( 3, buffer.Position );
				Assert.AreEqual( -32768L, result );
			}
		}
		
		[Test]
		public void TestUnpackInt16_ByteArray_SByteMinValueMinusOneAsInt64_Fail()
		{
			var result = Unpacking.UnpackInt16( new byte[] { 0xD3, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0x7F } );
			Assert.AreEqual( 9, result.ReadCount );
			Assert.AreEqual( -129L, result.Value );
		}
		
		[Test]
		public void TestUnpackInt16_Stream_SByteMinValueMinusOneAsInt64_Fail()
		{
			using ( var buffer = new MemoryStream( new byte[] { 0xD3, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0x7F } ) )
			{
				var result = Unpacking.UnpackInt16( buffer );
				Assert.AreEqual( 9, buffer.Position );
				Assert.AreEqual( -129L, result );
			}
		}
		
		[Test]
		public void TestUnpackInt16_ByteArray_SByteMinValueMinusOneAsInt32_Fail()
		{
			var result = Unpacking.UnpackInt16( new byte[] { 0xD2, 0xFF, 0xFF, 0xFF, 0x7F } );
			Assert.AreEqual( 5, result.ReadCount );
			Assert.AreEqual( -129L, result.Value );
		}
		
		[Test]
		public void TestUnpackInt16_Stream_SByteMinValueMinusOneAsInt32_Fail()
		{
			using ( var buffer = new MemoryStream( new byte[] { 0xD2, 0xFF, 0xFF, 0xFF, 0x7F } ) )
			{
				var result = Unpacking.UnpackInt16( buffer );
				Assert.AreEqual( 5, buffer.Position );
				Assert.AreEqual( -129L, result );
			}
		}
		
		[Test]
		public void TestUnpackInt16_ByteArray_SByteMinValueMinusOneAsInt16_Fail()
		{
			var result = Unpacking.UnpackInt16( new byte[] { 0xD1, 0xFF, 0x7F } );
			Assert.AreEqual( 3, result.ReadCount );
			Assert.AreEqual( -129L, result.Value );
		}
		
		[Test]
		public void TestUnpackInt16_Stream_SByteMinValueMinusOneAsInt16_Fail()
		{
			using ( var buffer = new MemoryStream( new byte[] { 0xD1, 0xFF, 0x7F } ) )
			{
				var result = Unpacking.UnpackInt16( buffer );
				Assert.AreEqual( 3, buffer.Position );
				Assert.AreEqual( -129L, result );
			}
		}
		
		[Test]
		public void TestUnpackInt16_ByteArray_SByteMinValueAsInt64_Fail()
		{
			var result = Unpacking.UnpackInt16( new byte[] { 0xD3, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0x80 } );
			Assert.AreEqual( 9, result.ReadCount );
			Assert.AreEqual( -128L, result.Value );
		}
		
		[Test]
		public void TestUnpackInt16_Stream_SByteMinValueAsInt64_Fail()
		{
			using ( var buffer = new MemoryStream( new byte[] { 0xD3, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0x80 } ) )
			{
				var result = Unpacking.UnpackInt16( buffer );
				Assert.AreEqual( 9, buffer.Position );
				Assert.AreEqual( -128L, result );
			}
		}
		
		[Test]
		public void TestUnpackInt16_ByteArray_SByteMinValueAsInt32_Fail()
		{
			var result = Unpacking.UnpackInt16( new byte[] { 0xD2, 0xFF, 0xFF, 0xFF, 0x80 } );
			Assert.AreEqual( 5, result.ReadCount );
			Assert.AreEqual( -128L, result.Value );
		}
		
		[Test]
		public void TestUnpackInt16_Stream_SByteMinValueAsInt32_Fail()
		{
			using ( var buffer = new MemoryStream( new byte[] { 0xD2, 0xFF, 0xFF, 0xFF, 0x80 } ) )
			{
				var result = Unpacking.UnpackInt16( buffer );
				Assert.AreEqual( 5, buffer.Position );
				Assert.AreEqual( -128L, result );
			}
		}
		
		[Test]
		public void TestUnpackInt16_ByteArray_SByteMinValueAsInt16_Fail()
		{
			var result = Unpacking.UnpackInt16( new byte[] { 0xD1, 0xFF, 0x80 } );
			Assert.AreEqual( 3, result.ReadCount );
			Assert.AreEqual( -128L, result.Value );
		}
		
		[Test]
		public void TestUnpackInt16_Stream_SByteMinValueAsInt16_Fail()
		{
			using ( var buffer = new MemoryStream( new byte[] { 0xD1, 0xFF, 0x80 } ) )
			{
				var result = Unpacking.UnpackInt16( buffer );
				Assert.AreEqual( 3, buffer.Position );
				Assert.AreEqual( -128L, result );
			}
		}
		
		[Test]
		public void TestUnpackInt16_ByteArray_SByteMinValueAsInt8_Fail()
		{
			var result = Unpacking.UnpackInt16( new byte[] { 0xD0, 0x80 } );
			Assert.AreEqual( 2, result.ReadCount );
			Assert.AreEqual( -128L, result.Value );
		}
		
		[Test]
		public void TestUnpackInt16_Stream_SByteMinValueAsInt8_Fail()
		{
			using ( var buffer = new MemoryStream( new byte[] { 0xD0, 0x80 } ) )
			{
				var result = Unpacking.UnpackInt16( buffer );
				Assert.AreEqual( 2, buffer.Position );
				Assert.AreEqual( -128L, result );
			}
		}
		
		[Test]
		public void TestUnpackInt16_ByteArray_NegativeFixNumMinValueMinusOneAsInt64_Fail()
		{
			var result = Unpacking.UnpackInt16( new byte[] { 0xD3, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xDF } );
			Assert.AreEqual( 9, result.ReadCount );
			Assert.AreEqual( -33L, result.Value );
		}
		
		[Test]
		public void TestUnpackInt16_Stream_NegativeFixNumMinValueMinusOneAsInt64_Fail()
		{
			using ( var buffer = new MemoryStream( new byte[] { 0xD3, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xDF } ) )
			{
				var result = Unpacking.UnpackInt16( buffer );
				Assert.AreEqual( 9, buffer.Position );
				Assert.AreEqual( -33L, result );
			}
		}
		
		[Test]
		public void TestUnpackInt16_ByteArray_NegativeFixNumMinValueMinusOneAsInt32_Fail()
		{
			var result = Unpacking.UnpackInt16( new byte[] { 0xD2, 0xFF, 0xFF, 0xFF, 0xDF } );
			Assert.AreEqual( 5, result.ReadCount );
			Assert.AreEqual( -33L, result.Value );
		}
		
		[Test]
		public void TestUnpackInt16_Stream_NegativeFixNumMinValueMinusOneAsInt32_Fail()
		{
			using ( var buffer = new MemoryStream( new byte[] { 0xD2, 0xFF, 0xFF, 0xFF, 0xDF } ) )
			{
				var result = Unpacking.UnpackInt16( buffer );
				Assert.AreEqual( 5, buffer.Position );
				Assert.AreEqual( -33L, result );
			}
		}
		
		[Test]
		public void TestUnpackInt16_ByteArray_NegativeFixNumMinValueMinusOneAsInt16_Fail()
		{
			var result = Unpacking.UnpackInt16( new byte[] { 0xD1, 0xFF, 0xDF } );
			Assert.AreEqual( 3, result.ReadCount );
			Assert.AreEqual( -33L, result.Value );
		}
		
		[Test]
		public void TestUnpackInt16_Stream_NegativeFixNumMinValueMinusOneAsInt16_Fail()
		{
			using ( var buffer = new MemoryStream( new byte[] { 0xD1, 0xFF, 0xDF } ) )
			{
				var result = Unpacking.UnpackInt16( buffer );
				Assert.AreEqual( 3, buffer.Position );
				Assert.AreEqual( -33L, result );
			}
		}
		
		[Test]
		public void TestUnpackInt16_ByteArray_NegativeFixNumMinValueMinusOneAsInt8_Fail()
		{
			var result = Unpacking.UnpackInt16( new byte[] { 0xD0, 0xDF } );
			Assert.AreEqual( 2, result.ReadCount );
			Assert.AreEqual( -33L, result.Value );
		}
		
		[Test]
		public void TestUnpackInt16_Stream_NegativeFixNumMinValueMinusOneAsInt8_Fail()
		{
			using ( var buffer = new MemoryStream( new byte[] { 0xD0, 0xDF } ) )
			{
				var result = Unpacking.UnpackInt16( buffer );
				Assert.AreEqual( 2, buffer.Position );
				Assert.AreEqual( -33L, result );
			}
		}
		
		[Test]
		public void TestUnpackInt16_ByteArray_NegativeFixNumMinValueAsInt64_Fail()
		{
			var result = Unpacking.UnpackInt16( new byte[] { 0xD3, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xE0 } );
			Assert.AreEqual( 9, result.ReadCount );
			Assert.AreEqual( -32L, result.Value );
		}
		
		[Test]
		public void TestUnpackInt16_Stream_NegativeFixNumMinValueAsInt64_Fail()
		{
			using ( var buffer = new MemoryStream( new byte[] { 0xD3, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xE0 } ) )
			{
				var result = Unpacking.UnpackInt16( buffer );
				Assert.AreEqual( 9, buffer.Position );
				Assert.AreEqual( -32L, result );
			}
		}
		
		[Test]
		public void TestUnpackInt16_ByteArray_NegativeFixNumMinValueAsInt32_Fail()
		{
			var result = Unpacking.UnpackInt16( new byte[] { 0xD2, 0xFF, 0xFF, 0xFF, 0xE0 } );
			Assert.AreEqual( 5, result.ReadCount );
			Assert.AreEqual( -32L, result.Value );
		}
		
		[Test]
		public void TestUnpackInt16_Stream_NegativeFixNumMinValueAsInt32_Fail()
		{
			using ( var buffer = new MemoryStream( new byte[] { 0xD2, 0xFF, 0xFF, 0xFF, 0xE0 } ) )
			{
				var result = Unpacking.UnpackInt16( buffer );
				Assert.AreEqual( 5, buffer.Position );
				Assert.AreEqual( -32L, result );
			}
		}
		
		[Test]
		public void TestUnpackInt16_ByteArray_NegativeFixNumMinValueAsInt16_Fail()
		{
			var result = Unpacking.UnpackInt16( new byte[] { 0xD1, 0xFF, 0xE0 } );
			Assert.AreEqual( 3, result.ReadCount );
			Assert.AreEqual( -32L, result.Value );
		}
		
		[Test]
		public void TestUnpackInt16_Stream_NegativeFixNumMinValueAsInt16_Fail()
		{
			using ( var buffer = new MemoryStream( new byte[] { 0xD1, 0xFF, 0xE0 } ) )
			{
				var result = Unpacking.UnpackInt16( buffer );
				Assert.AreEqual( 3, buffer.Position );
				Assert.AreEqual( -32L, result );
			}
		}
		
		[Test]
		public void TestUnpackInt16_ByteArray_NegativeFixNumMinValueAsInt8_Fail()
		{
			var result = Unpacking.UnpackInt16( new byte[] { 0xD0, 0xE0 } );
			Assert.AreEqual( 2, result.ReadCount );
			Assert.AreEqual( -32L, result.Value );
		}
		
		[Test]
		public void TestUnpackInt16_Stream_NegativeFixNumMinValueAsInt8_Fail()
		{
			using ( var buffer = new MemoryStream( new byte[] { 0xD0, 0xE0 } ) )
			{
				var result = Unpacking.UnpackInt16( buffer );
				Assert.AreEqual( 2, buffer.Position );
				Assert.AreEqual( -32L, result );
			}
		}
		
		[Test]
		public void TestUnpackInt16_ByteArray_NegativeFixNumMinValueAsNegativeFixNumMinus32_Fail()
		{
			var result = Unpacking.UnpackInt16( new byte[] { 0xE0 } );
			Assert.AreEqual( 1, result.ReadCount );
			Assert.AreEqual( -32L, result.Value );
		}
		
		[Test]
		public void TestUnpackInt16_Stream_NegativeFixNumMinValueAsNegativeFixNumMinus32_Fail()
		{
			using ( var buffer = new MemoryStream( new byte[] { 0xE0 } ) )
			{
				var result = Unpacking.UnpackInt16( buffer );
				Assert.AreEqual( 1, buffer.Position );
				Assert.AreEqual( -32L, result );
			}
		}
		
		[Test]
		public void TestUnpackInt16_ByteArray_MinusOneAsInt64_Fail()
		{
			var result = Unpacking.UnpackInt16( new byte[] { 0xD3, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF } );
			Assert.AreEqual( 9, result.ReadCount );
			Assert.AreEqual( -1L, result.Value );
		}
		
		[Test]
		public void TestUnpackInt16_Stream_MinusOneAsInt64_Fail()
		{
			using ( var buffer = new MemoryStream( new byte[] { 0xD3, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF } ) )
			{
				var result = Unpacking.UnpackInt16( buffer );
				Assert.AreEqual( 9, buffer.Position );
				Assert.AreEqual( -1L, result );
			}
		}
		
		[Test]
		public void TestUnpackInt16_ByteArray_MinusOneAsInt32_Fail()
		{
			var result = Unpacking.UnpackInt16( new byte[] { 0xD2, 0xFF, 0xFF, 0xFF, 0xFF } );
			Assert.AreEqual( 5, result.ReadCount );
			Assert.AreEqual( -1L, result.Value );
		}
		
		[Test]
		public void TestUnpackInt16_Stream_MinusOneAsInt32_Fail()
		{
			using ( var buffer = new MemoryStream( new byte[] { 0xD2, 0xFF, 0xFF, 0xFF, 0xFF } ) )
			{
				var result = Unpacking.UnpackInt16( buffer );
				Assert.AreEqual( 5, buffer.Position );
				Assert.AreEqual( -1L, result );
			}
		}
		
		[Test]
		public void TestUnpackInt16_ByteArray_MinusOneAsInt16_Fail()
		{
			var result = Unpacking.UnpackInt16( new byte[] { 0xD1, 0xFF, 0xFF } );
			Assert.AreEqual( 3, result.ReadCount );
			Assert.AreEqual( -1L, result.Value );
		}
		
		[Test]
		public void TestUnpackInt16_Stream_MinusOneAsInt16_Fail()
		{
			using ( var buffer = new MemoryStream( new byte[] { 0xD1, 0xFF, 0xFF } ) )
			{
				var result = Unpacking.UnpackInt16( buffer );
				Assert.AreEqual( 3, buffer.Position );
				Assert.AreEqual( -1L, result );
			}
		}
		
		[Test]
		public void TestUnpackInt16_ByteArray_MinusOneAsInt8_Fail()
		{
			var result = Unpacking.UnpackInt16( new byte[] { 0xD0, 0xFF } );
			Assert.AreEqual( 2, result.ReadCount );
			Assert.AreEqual( -1L, result.Value );
		}
		
		[Test]
		public void TestUnpackInt16_Stream_MinusOneAsInt8_Fail()
		{
			using ( var buffer = new MemoryStream( new byte[] { 0xD0, 0xFF } ) )
			{
				var result = Unpacking.UnpackInt16( buffer );
				Assert.AreEqual( 2, buffer.Position );
				Assert.AreEqual( -1L, result );
			}
		}
		
		[Test]
		public void TestUnpackInt16_ByteArray_MinusOneAsNegativeFixNumMinus1_Fail()
		{
			var result = Unpacking.UnpackInt16( new byte[] { 0xFF } );
			Assert.AreEqual( 1, result.ReadCount );
			Assert.AreEqual( -1L, result.Value );
		}
		
		[Test]
		public void TestUnpackInt16_Stream_MinusOneAsNegativeFixNumMinus1_Fail()
		{
			using ( var buffer = new MemoryStream( new byte[] { 0xFF } ) )
			{
				var result = Unpacking.UnpackInt16( buffer );
				Assert.AreEqual( 1, buffer.Position );
				Assert.AreEqual( -1L, result );
			}
		}
		
		[Test]
		public void TestUnpackInt16_ByteArray_ZeroAsInt64_Fail()
		{
			var result = Unpacking.UnpackInt16( new byte[] { 0xD3, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 } );
			Assert.AreEqual( 9, result.ReadCount );
			Assert.AreEqual( 0L, result.Value );
		}
		
		[Test]
		public void TestUnpackInt16_Stream_ZeroAsInt64_Fail()
		{
			using ( var buffer = new MemoryStream( new byte[] { 0xD3, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 } ) )
			{
				var result = Unpacking.UnpackInt16( buffer );
				Assert.AreEqual( 9, buffer.Position );
				Assert.AreEqual( 0L, result );
			}
		}
		
		[Test]
		public void TestUnpackInt16_ByteArray_ZeroAsUInt64_Fail()
		{
			var result = Unpacking.UnpackInt16( new byte[] { 0xCF, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 } );
			Assert.AreEqual( 9, result.ReadCount );
			Assert.AreEqual( 0L, result.Value );
		}
		
		[Test]
		public void TestUnpackInt16_Stream_ZeroAsUInt64_Fail()
		{
			using ( var buffer = new MemoryStream( new byte[] { 0xCF, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 } ) )
			{
				var result = Unpacking.UnpackInt16( buffer );
				Assert.AreEqual( 9, buffer.Position );
				Assert.AreEqual( 0L, result );
			}
		}
		
		[Test]
		public void TestUnpackInt16_ByteArray_ZeroAsInt32_Fail()
		{
			var result = Unpacking.UnpackInt16( new byte[] { 0xD2, 0x00, 0x00, 0x00, 0x00 } );
			Assert.AreEqual( 5, result.ReadCount );
			Assert.AreEqual( 0L, result.Value );
		}
		
		[Test]
		public void TestUnpackInt16_Stream_ZeroAsInt32_Fail()
		{
			using ( var buffer = new MemoryStream( new byte[] { 0xD2, 0x00, 0x00, 0x00, 0x00 } ) )
			{
				var result = Unpacking.UnpackInt16( buffer );
				Assert.AreEqual( 5, buffer.Position );
				Assert.AreEqual( 0L, result );
			}
		}
		
		[Test]
		public void TestUnpackInt16_ByteArray_ZeroAsUInt32_Fail()
		{
			var result = Unpacking.UnpackInt16( new byte[] { 0xCE, 0x00, 0x00, 0x00, 0x00 } );
			Assert.AreEqual( 5, result.ReadCount );
			Assert.AreEqual( 0L, result.Value );
		}
		
		[Test]
		public void TestUnpackInt16_Stream_ZeroAsUInt32_Fail()
		{
			using ( var buffer = new MemoryStream( new byte[] { 0xCE, 0x00, 0x00, 0x00, 0x00 } ) )
			{
				var result = Unpacking.UnpackInt16( buffer );
				Assert.AreEqual( 5, buffer.Position );
				Assert.AreEqual( 0L, result );
			}
		}
		
		[Test]
		public void TestUnpackInt16_ByteArray_ZeroAsInt16_Fail()
		{
			var result = Unpacking.UnpackInt16( new byte[] { 0xD1, 0x00, 0x00 } );
			Assert.AreEqual( 3, result.ReadCount );
			Assert.AreEqual( 0L, result.Value );
		}
		
		[Test]
		public void TestUnpackInt16_Stream_ZeroAsInt16_Fail()
		{
			using ( var buffer = new MemoryStream( new byte[] { 0xD1, 0x00, 0x00 } ) )
			{
				var result = Unpacking.UnpackInt16( buffer );
				Assert.AreEqual( 3, buffer.Position );
				Assert.AreEqual( 0L, result );
			}
		}
		
		[Test]
		public void TestUnpackInt16_ByteArray_ZeroAsUInt16_Fail()
		{
			var result = Unpacking.UnpackInt16( new byte[] { 0xCD, 0x00, 0x00 } );
			Assert.AreEqual( 3, result.ReadCount );
			Assert.AreEqual( 0L, result.Value );
		}
		
		[Test]
		public void TestUnpackInt16_Stream_ZeroAsUInt16_Fail()
		{
			using ( var buffer = new MemoryStream( new byte[] { 0xCD, 0x00, 0x00 } ) )
			{
				var result = Unpacking.UnpackInt16( buffer );
				Assert.AreEqual( 3, buffer.Position );
				Assert.AreEqual( 0L, result );
			}
		}
		
		[Test]
		public void TestUnpackInt16_ByteArray_ZeroAsInt8_Fail()
		{
			var result = Unpacking.UnpackInt16( new byte[] { 0xD0, 0x00 } );
			Assert.AreEqual( 2, result.ReadCount );
			Assert.AreEqual( 0L, result.Value );
		}
		
		[Test]
		public void TestUnpackInt16_Stream_ZeroAsInt8_Fail()
		{
			using ( var buffer = new MemoryStream( new byte[] { 0xD0, 0x00 } ) )
			{
				var result = Unpacking.UnpackInt16( buffer );
				Assert.AreEqual( 2, buffer.Position );
				Assert.AreEqual( 0L, result );
			}
		}
		
		[Test]
		public void TestUnpackInt16_ByteArray_ZeroAsUInt8_Fail()
		{
			var result = Unpacking.UnpackInt16( new byte[] { 0xCC, 0x00 } );
			Assert.AreEqual( 2, result.ReadCount );
			Assert.AreEqual( 0L, result.Value );
		}
		
		[Test]
		public void TestUnpackInt16_Stream_ZeroAsUInt8_Fail()
		{
			using ( var buffer = new MemoryStream( new byte[] { 0xCC, 0x00 } ) )
			{
				var result = Unpacking.UnpackInt16( buffer );
				Assert.AreEqual( 2, buffer.Position );
				Assert.AreEqual( 0L, result );
			}
		}
		
		[Test]
		public void TestUnpackInt16_ByteArray_ZeroAsPositiveFixNum0_Fail()
		{
			var result = Unpacking.UnpackInt16( new byte[] { 0x00 } );
			Assert.AreEqual( 1, result.ReadCount );
			Assert.AreEqual( 0L, result.Value );
		}
		
		[Test]
		public void TestUnpackInt16_Stream_ZeroAsPositiveFixNum0_Fail()
		{
			using ( var buffer = new MemoryStream( new byte[] { 0x00 } ) )
			{
				var result = Unpacking.UnpackInt16( buffer );
				Assert.AreEqual( 1, buffer.Position );
				Assert.AreEqual( 0L, result );
			}
		}
		
		[Test]
		public void TestUnpackInt16_ByteArray_PlusOneAsInt64_Fail()
		{
			var result = Unpacking.UnpackInt16( new byte[] { 0xD3, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x01 } );
			Assert.AreEqual( 9, result.ReadCount );
			Assert.AreEqual( 1L, result.Value );
		}
		
		[Test]
		public void TestUnpackInt16_Stream_PlusOneAsInt64_Fail()
		{
			using ( var buffer = new MemoryStream( new byte[] { 0xD3, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x01 } ) )
			{
				var result = Unpacking.UnpackInt16( buffer );
				Assert.AreEqual( 9, buffer.Position );
				Assert.AreEqual( 1L, result );
			}
		}
		
		[Test]
		public void TestUnpackInt16_ByteArray_PlusOneAsUInt64_Fail()
		{
			var result = Unpacking.UnpackInt16( new byte[] { 0xCF, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x01 } );
			Assert.AreEqual( 9, result.ReadCount );
			Assert.AreEqual( 1L, result.Value );
		}
		
		[Test]
		public void TestUnpackInt16_Stream_PlusOneAsUInt64_Fail()
		{
			using ( var buffer = new MemoryStream( new byte[] { 0xCF, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x01 } ) )
			{
				var result = Unpacking.UnpackInt16( buffer );
				Assert.AreEqual( 9, buffer.Position );
				Assert.AreEqual( 1L, result );
			}
		}
		
		[Test]
		public void TestUnpackInt16_ByteArray_PlusOneAsInt32_Fail()
		{
			var result = Unpacking.UnpackInt16( new byte[] { 0xD2, 0x00, 0x00, 0x00, 0x01 } );
			Assert.AreEqual( 5, result.ReadCount );
			Assert.AreEqual( 1L, result.Value );
		}
		
		[Test]
		public void TestUnpackInt16_Stream_PlusOneAsInt32_Fail()
		{
			using ( var buffer = new MemoryStream( new byte[] { 0xD2, 0x00, 0x00, 0x00, 0x01 } ) )
			{
				var result = Unpacking.UnpackInt16( buffer );
				Assert.AreEqual( 5, buffer.Position );
				Assert.AreEqual( 1L, result );
			}
		}
		
		[Test]
		public void TestUnpackInt16_ByteArray_PlusOneAsUInt32_Fail()
		{
			var result = Unpacking.UnpackInt16( new byte[] { 0xCE, 0x00, 0x00, 0x00, 0x01 } );
			Assert.AreEqual( 5, result.ReadCount );
			Assert.AreEqual( 1L, result.Value );
		}
		
		[Test]
		public void TestUnpackInt16_Stream_PlusOneAsUInt32_Fail()
		{
			using ( var buffer = new MemoryStream( new byte[] { 0xCE, 0x00, 0x00, 0x00, 0x01 } ) )
			{
				var result = Unpacking.UnpackInt16( buffer );
				Assert.AreEqual( 5, buffer.Position );
				Assert.AreEqual( 1L, result );
			}
		}
		
		[Test]
		public void TestUnpackInt16_ByteArray_PlusOneAsInt16_Fail()
		{
			var result = Unpacking.UnpackInt16( new byte[] { 0xD1, 0x00, 0x01 } );
			Assert.AreEqual( 3, result.ReadCount );
			Assert.AreEqual( 1L, result.Value );
		}
		
		[Test]
		public void TestUnpackInt16_Stream_PlusOneAsInt16_Fail()
		{
			using ( var buffer = new MemoryStream( new byte[] { 0xD1, 0x00, 0x01 } ) )
			{
				var result = Unpacking.UnpackInt16( buffer );
				Assert.AreEqual( 3, buffer.Position );
				Assert.AreEqual( 1L, result );
			}
		}
		
		[Test]
		public void TestUnpackInt16_ByteArray_PlusOneAsUInt16_Fail()
		{
			var result = Unpacking.UnpackInt16( new byte[] { 0xCD, 0x00, 0x01 } );
			Assert.AreEqual( 3, result.ReadCount );
			Assert.AreEqual( 1L, result.Value );
		}
		
		[Test]
		public void TestUnpackInt16_Stream_PlusOneAsUInt16_Fail()
		{
			using ( var buffer = new MemoryStream( new byte[] { 0xCD, 0x00, 0x01 } ) )
			{
				var result = Unpacking.UnpackInt16( buffer );
				Assert.AreEqual( 3, buffer.Position );
				Assert.AreEqual( 1L, result );
			}
		}
		
		[Test]
		public void TestUnpackInt16_ByteArray_PlusOneAsInt8_Fail()
		{
			var result = Unpacking.UnpackInt16( new byte[] { 0xD0, 0x01 } );
			Assert.AreEqual( 2, result.ReadCount );
			Assert.AreEqual( 1L, result.Value );
		}
		
		[Test]
		public void TestUnpackInt16_Stream_PlusOneAsInt8_Fail()
		{
			using ( var buffer = new MemoryStream( new byte[] { 0xD0, 0x01 } ) )
			{
				var result = Unpacking.UnpackInt16( buffer );
				Assert.AreEqual( 2, buffer.Position );
				Assert.AreEqual( 1L, result );
			}
		}
		
		[Test]
		public void TestUnpackInt16_ByteArray_PlusOneAsUInt8_Fail()
		{
			var result = Unpacking.UnpackInt16( new byte[] { 0xCC, 0x01 } );
			Assert.AreEqual( 2, result.ReadCount );
			Assert.AreEqual( 1L, result.Value );
		}
		
		[Test]
		public void TestUnpackInt16_Stream_PlusOneAsUInt8_Fail()
		{
			using ( var buffer = new MemoryStream( new byte[] { 0xCC, 0x01 } ) )
			{
				var result = Unpacking.UnpackInt16( buffer );
				Assert.AreEqual( 2, buffer.Position );
				Assert.AreEqual( 1L, result );
			}
		}
		
		[Test]
		public void TestUnpackInt16_ByteArray_PlusOneAsPositiveFixNum1_Fail()
		{
			var result = Unpacking.UnpackInt16( new byte[] { 0x01 } );
			Assert.AreEqual( 1, result.ReadCount );
			Assert.AreEqual( 1L, result.Value );
		}
		
		[Test]
		public void TestUnpackInt16_Stream_PlusOneAsPositiveFixNum1_Fail()
		{
			using ( var buffer = new MemoryStream( new byte[] { 0x01 } ) )
			{
				var result = Unpacking.UnpackInt16( buffer );
				Assert.AreEqual( 1, buffer.Position );
				Assert.AreEqual( 1L, result );
			}
		}
		
		[Test]
		public void TestUnpackInt16_ByteArray_PositiveFixNumMaxValueAsInt64_Fail()
		{
			var result = Unpacking.UnpackInt16( new byte[] { 0xD3, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x7F } );
			Assert.AreEqual( 9, result.ReadCount );
			Assert.AreEqual( 127L, result.Value );
		}
		
		[Test]
		public void TestUnpackInt16_Stream_PositiveFixNumMaxValueAsInt64_Fail()
		{
			using ( var buffer = new MemoryStream( new byte[] { 0xD3, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x7F } ) )
			{
				var result = Unpacking.UnpackInt16( buffer );
				Assert.AreEqual( 9, buffer.Position );
				Assert.AreEqual( 127L, result );
			}
		}
		
		[Test]
		public void TestUnpackInt16_ByteArray_PositiveFixNumMaxValueAsUInt64_Fail()
		{
			var result = Unpacking.UnpackInt16( new byte[] { 0xCF, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x7F } );
			Assert.AreEqual( 9, result.ReadCount );
			Assert.AreEqual( 127L, result.Value );
		}
		
		[Test]
		public void TestUnpackInt16_Stream_PositiveFixNumMaxValueAsUInt64_Fail()
		{
			using ( var buffer = new MemoryStream( new byte[] { 0xCF, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x7F } ) )
			{
				var result = Unpacking.UnpackInt16( buffer );
				Assert.AreEqual( 9, buffer.Position );
				Assert.AreEqual( 127L, result );
			}
		}
		
		[Test]
		public void TestUnpackInt16_ByteArray_PositiveFixNumMaxValueAsInt32_Fail()
		{
			var result = Unpacking.UnpackInt16( new byte[] { 0xD2, 0x00, 0x00, 0x00, 0x7F } );
			Assert.AreEqual( 5, result.ReadCount );
			Assert.AreEqual( 127L, result.Value );
		}
		
		[Test]
		public void TestUnpackInt16_Stream_PositiveFixNumMaxValueAsInt32_Fail()
		{
			using ( var buffer = new MemoryStream( new byte[] { 0xD2, 0x00, 0x00, 0x00, 0x7F } ) )
			{
				var result = Unpacking.UnpackInt16( buffer );
				Assert.AreEqual( 5, buffer.Position );
				Assert.AreEqual( 127L, result );
			}
		}
		
		[Test]
		public void TestUnpackInt16_ByteArray_PositiveFixNumMaxValueAsUInt32_Fail()
		{
			var result = Unpacking.UnpackInt16( new byte[] { 0xCE, 0x00, 0x00, 0x00, 0x7F } );
			Assert.AreEqual( 5, result.ReadCount );
			Assert.AreEqual( 127L, result.Value );
		}
		
		[Test]
		public void TestUnpackInt16_Stream_PositiveFixNumMaxValueAsUInt32_Fail()
		{
			using ( var buffer = new MemoryStream( new byte[] { 0xCE, 0x00, 0x00, 0x00, 0x7F } ) )
			{
				var result = Unpacking.UnpackInt16( buffer );
				Assert.AreEqual( 5, buffer.Position );
				Assert.AreEqual( 127L, result );
			}
		}
		
		[Test]
		public void TestUnpackInt16_ByteArray_PositiveFixNumMaxValueAsInt16_Fail()
		{
			var result = Unpacking.UnpackInt16( new byte[] { 0xD1, 0x00, 0x7F } );
			Assert.AreEqual( 3, result.ReadCount );
			Assert.AreEqual( 127L, result.Value );
		}
		
		[Test]
		public void TestUnpackInt16_Stream_PositiveFixNumMaxValueAsInt16_Fail()
		{
			using ( var buffer = new MemoryStream( new byte[] { 0xD1, 0x00, 0x7F } ) )
			{
				var result = Unpacking.UnpackInt16( buffer );
				Assert.AreEqual( 3, buffer.Position );
				Assert.AreEqual( 127L, result );
			}
		}
		
		[Test]
		public void TestUnpackInt16_ByteArray_PositiveFixNumMaxValueAsUInt16_Fail()
		{
			var result = Unpacking.UnpackInt16( new byte[] { 0xCD, 0x00, 0x7F } );
			Assert.AreEqual( 3, result.ReadCount );
			Assert.AreEqual( 127L, result.Value );
		}
		
		[Test]
		public void TestUnpackInt16_Stream_PositiveFixNumMaxValueAsUInt16_Fail()
		{
			using ( var buffer = new MemoryStream( new byte[] { 0xCD, 0x00, 0x7F } ) )
			{
				var result = Unpacking.UnpackInt16( buffer );
				Assert.AreEqual( 3, buffer.Position );
				Assert.AreEqual( 127L, result );
			}
		}
		
		[Test]
		public void TestUnpackInt16_ByteArray_PositiveFixNumMaxValueAsInt8_Fail()
		{
			var result = Unpacking.UnpackInt16( new byte[] { 0xD0, 0x7F } );
			Assert.AreEqual( 2, result.ReadCount );
			Assert.AreEqual( 127L, result.Value );
		}
		
		[Test]
		public void TestUnpackInt16_Stream_PositiveFixNumMaxValueAsInt8_Fail()
		{
			using ( var buffer = new MemoryStream( new byte[] { 0xD0, 0x7F } ) )
			{
				var result = Unpacking.UnpackInt16( buffer );
				Assert.AreEqual( 2, buffer.Position );
				Assert.AreEqual( 127L, result );
			}
		}
		
		[Test]
		public void TestUnpackInt16_ByteArray_PositiveFixNumMaxValueAsUInt8_Fail()
		{
			var result = Unpacking.UnpackInt16( new byte[] { 0xCC, 0x7F } );
			Assert.AreEqual( 2, result.ReadCount );
			Assert.AreEqual( 127L, result.Value );
		}
		
		[Test]
		public void TestUnpackInt16_Stream_PositiveFixNumMaxValueAsUInt8_Fail()
		{
			using ( var buffer = new MemoryStream( new byte[] { 0xCC, 0x7F } ) )
			{
				var result = Unpacking.UnpackInt16( buffer );
				Assert.AreEqual( 2, buffer.Position );
				Assert.AreEqual( 127L, result );
			}
		}
		
		[Test]
		public void TestUnpackInt16_ByteArray_PositiveFixNumMaxValueAsPositiveFixNum127_Fail()
		{
			var result = Unpacking.UnpackInt16( new byte[] { 0x7F } );
			Assert.AreEqual( 1, result.ReadCount );
			Assert.AreEqual( 127L, result.Value );
		}
		
		[Test]
		public void TestUnpackInt16_Stream_PositiveFixNumMaxValueAsPositiveFixNum127_Fail()
		{
			using ( var buffer = new MemoryStream( new byte[] { 0x7F } ) )
			{
				var result = Unpacking.UnpackInt16( buffer );
				Assert.AreEqual( 1, buffer.Position );
				Assert.AreEqual( 127L, result );
			}
		}
		
		[Test]
		public void TestUnpackInt16_ByteArray_PositiveFixNumMaxValuePlusOneAsInt64_Fail()
		{
			var result = Unpacking.UnpackInt16( new byte[] { 0xD3, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x80 } );
			Assert.AreEqual( 9, result.ReadCount );
			Assert.AreEqual( 128L, result.Value );
		}
		
		[Test]
		public void TestUnpackInt16_Stream_PositiveFixNumMaxValuePlusOneAsInt64_Fail()
		{
			using ( var buffer = new MemoryStream( new byte[] { 0xD3, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x80 } ) )
			{
				var result = Unpacking.UnpackInt16( buffer );
				Assert.AreEqual( 9, buffer.Position );
				Assert.AreEqual( 128L, result );
			}
		}
		
		[Test]
		public void TestUnpackInt16_ByteArray_PositiveFixNumMaxValuePlusOneAsUInt64_Fail()
		{
			var result = Unpacking.UnpackInt16( new byte[] { 0xCF, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x80 } );
			Assert.AreEqual( 9, result.ReadCount );
			Assert.AreEqual( 128L, result.Value );
		}
		
		[Test]
		public void TestUnpackInt16_Stream_PositiveFixNumMaxValuePlusOneAsUInt64_Fail()
		{
			using ( var buffer = new MemoryStream( new byte[] { 0xCF, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x80 } ) )
			{
				var result = Unpacking.UnpackInt16( buffer );
				Assert.AreEqual( 9, buffer.Position );
				Assert.AreEqual( 128L, result );
			}
		}
		
		[Test]
		public void TestUnpackInt16_ByteArray_PositiveFixNumMaxValuePlusOneAsInt32_Fail()
		{
			var result = Unpacking.UnpackInt16( new byte[] { 0xD2, 0x00, 0x00, 0x00, 0x80 } );
			Assert.AreEqual( 5, result.ReadCount );
			Assert.AreEqual( 128L, result.Value );
		}
		
		[Test]
		public void TestUnpackInt16_Stream_PositiveFixNumMaxValuePlusOneAsInt32_Fail()
		{
			using ( var buffer = new MemoryStream( new byte[] { 0xD2, 0x00, 0x00, 0x00, 0x80 } ) )
			{
				var result = Unpacking.UnpackInt16( buffer );
				Assert.AreEqual( 5, buffer.Position );
				Assert.AreEqual( 128L, result );
			}
		}
		
		[Test]
		public void TestUnpackInt16_ByteArray_PositiveFixNumMaxValuePlusOneAsUInt32_Fail()
		{
			var result = Unpacking.UnpackInt16( new byte[] { 0xCE, 0x00, 0x00, 0x00, 0x80 } );
			Assert.AreEqual( 5, result.ReadCount );
			Assert.AreEqual( 128L, result.Value );
		}
		
		[Test]
		public void TestUnpackInt16_Stream_PositiveFixNumMaxValuePlusOneAsUInt32_Fail()
		{
			using ( var buffer = new MemoryStream( new byte[] { 0xCE, 0x00, 0x00, 0x00, 0x80 } ) )
			{
				var result = Unpacking.UnpackInt16( buffer );
				Assert.AreEqual( 5, buffer.Position );
				Assert.AreEqual( 128L, result );
			}
		}
		
		[Test]
		public void TestUnpackInt16_ByteArray_PositiveFixNumMaxValuePlusOneAsInt16_Fail()
		{
			var result = Unpacking.UnpackInt16( new byte[] { 0xD1, 0x00, 0x80 } );
			Assert.AreEqual( 3, result.ReadCount );
			Assert.AreEqual( 128L, result.Value );
		}
		
		[Test]
		public void TestUnpackInt16_Stream_PositiveFixNumMaxValuePlusOneAsInt16_Fail()
		{
			using ( var buffer = new MemoryStream( new byte[] { 0xD1, 0x00, 0x80 } ) )
			{
				var result = Unpacking.UnpackInt16( buffer );
				Assert.AreEqual( 3, buffer.Position );
				Assert.AreEqual( 128L, result );
			}
		}
		
		[Test]
		public void TestUnpackInt16_ByteArray_PositiveFixNumMaxValuePlusOneAsUInt16_Fail()
		{
			var result = Unpacking.UnpackInt16( new byte[] { 0xCD, 0x00, 0x80 } );
			Assert.AreEqual( 3, result.ReadCount );
			Assert.AreEqual( 128L, result.Value );
		}
		
		[Test]
		public void TestUnpackInt16_Stream_PositiveFixNumMaxValuePlusOneAsUInt16_Fail()
		{
			using ( var buffer = new MemoryStream( new byte[] { 0xCD, 0x00, 0x80 } ) )
			{
				var result = Unpacking.UnpackInt16( buffer );
				Assert.AreEqual( 3, buffer.Position );
				Assert.AreEqual( 128L, result );
			}
		}
		
		[Test]
		public void TestUnpackInt16_ByteArray_PositiveFixNumMaxValuePlusOneAsUInt8_Fail()
		{
			var result = Unpacking.UnpackInt16( new byte[] { 0xCC, 0x80 } );
			Assert.AreEqual( 2, result.ReadCount );
			Assert.AreEqual( 128L, result.Value );
		}
		
		[Test]
		public void TestUnpackInt16_Stream_PositiveFixNumMaxValuePlusOneAsUInt8_Fail()
		{
			using ( var buffer = new MemoryStream( new byte[] { 0xCC, 0x80 } ) )
			{
				var result = Unpacking.UnpackInt16( buffer );
				Assert.AreEqual( 2, buffer.Position );
				Assert.AreEqual( 128L, result );
			}
		}
		
		[Test]
		public void TestUnpackInt16_ByteArray_ByteMaxValueAsInt64_Fail()
		{
			var result = Unpacking.UnpackInt16( new byte[] { 0xD3, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0xFF } );
			Assert.AreEqual( 9, result.ReadCount );
			Assert.AreEqual( 255L, result.Value );
		}
		
		[Test]
		public void TestUnpackInt16_Stream_ByteMaxValueAsInt64_Fail()
		{
			using ( var buffer = new MemoryStream( new byte[] { 0xD3, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0xFF } ) )
			{
				var result = Unpacking.UnpackInt16( buffer );
				Assert.AreEqual( 9, buffer.Position );
				Assert.AreEqual( 255L, result );
			}
		}
		
		[Test]
		public void TestUnpackInt16_ByteArray_ByteMaxValueAsUInt64_Fail()
		{
			var result = Unpacking.UnpackInt16( new byte[] { 0xCF, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0xFF } );
			Assert.AreEqual( 9, result.ReadCount );
			Assert.AreEqual( 255L, result.Value );
		}
		
		[Test]
		public void TestUnpackInt16_Stream_ByteMaxValueAsUInt64_Fail()
		{
			using ( var buffer = new MemoryStream( new byte[] { 0xCF, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0xFF } ) )
			{
				var result = Unpacking.UnpackInt16( buffer );
				Assert.AreEqual( 9, buffer.Position );
				Assert.AreEqual( 255L, result );
			}
		}
		
		[Test]
		public void TestUnpackInt16_ByteArray_ByteMaxValueAsInt32_Fail()
		{
			var result = Unpacking.UnpackInt16( new byte[] { 0xD2, 0x00, 0x00, 0x00, 0xFF } );
			Assert.AreEqual( 5, result.ReadCount );
			Assert.AreEqual( 255L, result.Value );
		}
		
		[Test]
		public void TestUnpackInt16_Stream_ByteMaxValueAsInt32_Fail()
		{
			using ( var buffer = new MemoryStream( new byte[] { 0xD2, 0x00, 0x00, 0x00, 0xFF } ) )
			{
				var result = Unpacking.UnpackInt16( buffer );
				Assert.AreEqual( 5, buffer.Position );
				Assert.AreEqual( 255L, result );
			}
		}
		
		[Test]
		public void TestUnpackInt16_ByteArray_ByteMaxValueAsUInt32_Fail()
		{
			var result = Unpacking.UnpackInt16( new byte[] { 0xCE, 0x00, 0x00, 0x00, 0xFF } );
			Assert.AreEqual( 5, result.ReadCount );
			Assert.AreEqual( 255L, result.Value );
		}
		
		[Test]
		public void TestUnpackInt16_Stream_ByteMaxValueAsUInt32_Fail()
		{
			using ( var buffer = new MemoryStream( new byte[] { 0xCE, 0x00, 0x00, 0x00, 0xFF } ) )
			{
				var result = Unpacking.UnpackInt16( buffer );
				Assert.AreEqual( 5, buffer.Position );
				Assert.AreEqual( 255L, result );
			}
		}
		
		[Test]
		public void TestUnpackInt16_ByteArray_ByteMaxValueAsInt16_Fail()
		{
			var result = Unpacking.UnpackInt16( new byte[] { 0xD1, 0x00, 0xFF } );
			Assert.AreEqual( 3, result.ReadCount );
			Assert.AreEqual( 255L, result.Value );
		}
		
		[Test]
		public void TestUnpackInt16_Stream_ByteMaxValueAsInt16_Fail()
		{
			using ( var buffer = new MemoryStream( new byte[] { 0xD1, 0x00, 0xFF } ) )
			{
				var result = Unpacking.UnpackInt16( buffer );
				Assert.AreEqual( 3, buffer.Position );
				Assert.AreEqual( 255L, result );
			}
		}
		
		[Test]
		public void TestUnpackInt16_ByteArray_ByteMaxValueAsUInt16_Fail()
		{
			var result = Unpacking.UnpackInt16( new byte[] { 0xCD, 0x00, 0xFF } );
			Assert.AreEqual( 3, result.ReadCount );
			Assert.AreEqual( 255L, result.Value );
		}
		
		[Test]
		public void TestUnpackInt16_Stream_ByteMaxValueAsUInt16_Fail()
		{
			using ( var buffer = new MemoryStream( new byte[] { 0xCD, 0x00, 0xFF } ) )
			{
				var result = Unpacking.UnpackInt16( buffer );
				Assert.AreEqual( 3, buffer.Position );
				Assert.AreEqual( 255L, result );
			}
		}
		
		[Test]
		public void TestUnpackInt16_ByteArray_ByteMaxValueAsUInt8_Fail()
		{
			var result = Unpacking.UnpackInt16( new byte[] { 0xCC, 0xFF } );
			Assert.AreEqual( 2, result.ReadCount );
			Assert.AreEqual( 255L, result.Value );
		}
		
		[Test]
		public void TestUnpackInt16_Stream_ByteMaxValueAsUInt8_Fail()
		{
			using ( var buffer = new MemoryStream( new byte[] { 0xCC, 0xFF } ) )
			{
				var result = Unpacking.UnpackInt16( buffer );
				Assert.AreEqual( 2, buffer.Position );
				Assert.AreEqual( 255L, result );
			}
		}
		
		[Test]
		public void TestUnpackInt16_ByteArray_ByteMaxValuePlusOneAsInt64_Fail()
		{
			var result = Unpacking.UnpackInt16( new byte[] { 0xD3, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x01, 0x00 } );
			Assert.AreEqual( 9, result.ReadCount );
			Assert.AreEqual( 256L, result.Value );
		}
		
		[Test]
		public void TestUnpackInt16_Stream_ByteMaxValuePlusOneAsInt64_Fail()
		{
			using ( var buffer = new MemoryStream( new byte[] { 0xD3, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x01, 0x00 } ) )
			{
				var result = Unpacking.UnpackInt16( buffer );
				Assert.AreEqual( 9, buffer.Position );
				Assert.AreEqual( 256L, result );
			}
		}
		
		[Test]
		public void TestUnpackInt16_ByteArray_ByteMaxValuePlusOneAsUInt64_Fail()
		{
			var result = Unpacking.UnpackInt16( new byte[] { 0xCF, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x01, 0x00 } );
			Assert.AreEqual( 9, result.ReadCount );
			Assert.AreEqual( 256L, result.Value );
		}
		
		[Test]
		public void TestUnpackInt16_Stream_ByteMaxValuePlusOneAsUInt64_Fail()
		{
			using ( var buffer = new MemoryStream( new byte[] { 0xCF, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x01, 0x00 } ) )
			{
				var result = Unpacking.UnpackInt16( buffer );
				Assert.AreEqual( 9, buffer.Position );
				Assert.AreEqual( 256L, result );
			}
		}
		
		[Test]
		public void TestUnpackInt16_ByteArray_ByteMaxValuePlusOneAsInt32_Fail()
		{
			var result = Unpacking.UnpackInt16( new byte[] { 0xD2, 0x00, 0x00, 0x01, 0x00 } );
			Assert.AreEqual( 5, result.ReadCount );
			Assert.AreEqual( 256L, result.Value );
		}
		
		[Test]
		public void TestUnpackInt16_Stream_ByteMaxValuePlusOneAsInt32_Fail()
		{
			using ( var buffer = new MemoryStream( new byte[] { 0xD2, 0x00, 0x00, 0x01, 0x00 } ) )
			{
				var result = Unpacking.UnpackInt16( buffer );
				Assert.AreEqual( 5, buffer.Position );
				Assert.AreEqual( 256L, result );
			}
		}
		
		[Test]
		public void TestUnpackInt16_ByteArray_ByteMaxValuePlusOneAsUInt32_Fail()
		{
			var result = Unpacking.UnpackInt16( new byte[] { 0xCE, 0x00, 0x00, 0x01, 0x00 } );
			Assert.AreEqual( 5, result.ReadCount );
			Assert.AreEqual( 256L, result.Value );
		}
		
		[Test]
		public void TestUnpackInt16_Stream_ByteMaxValuePlusOneAsUInt32_Fail()
		{
			using ( var buffer = new MemoryStream( new byte[] { 0xCE, 0x00, 0x00, 0x01, 0x00 } ) )
			{
				var result = Unpacking.UnpackInt16( buffer );
				Assert.AreEqual( 5, buffer.Position );
				Assert.AreEqual( 256L, result );
			}
		}
		
		[Test]
		public void TestUnpackInt16_ByteArray_ByteMaxValuePlusOneAsInt16_Fail()
		{
			var result = Unpacking.UnpackInt16( new byte[] { 0xD1, 0x01, 0x00 } );
			Assert.AreEqual( 3, result.ReadCount );
			Assert.AreEqual( 256L, result.Value );
		}
		
		[Test]
		public void TestUnpackInt16_Stream_ByteMaxValuePlusOneAsInt16_Fail()
		{
			using ( var buffer = new MemoryStream( new byte[] { 0xD1, 0x01, 0x00 } ) )
			{
				var result = Unpacking.UnpackInt16( buffer );
				Assert.AreEqual( 3, buffer.Position );
				Assert.AreEqual( 256L, result );
			}
		}
		
		[Test]
		public void TestUnpackInt16_ByteArray_ByteMaxValuePlusOneAsUInt16_Fail()
		{
			var result = Unpacking.UnpackInt16( new byte[] { 0xCD, 0x01, 0x00 } );
			Assert.AreEqual( 3, result.ReadCount );
			Assert.AreEqual( 256L, result.Value );
		}
		
		[Test]
		public void TestUnpackInt16_Stream_ByteMaxValuePlusOneAsUInt16_Fail()
		{
			using ( var buffer = new MemoryStream( new byte[] { 0xCD, 0x01, 0x00 } ) )
			{
				var result = Unpacking.UnpackInt16( buffer );
				Assert.AreEqual( 3, buffer.Position );
				Assert.AreEqual( 256L, result );
			}
		}
		
		[Test]
		[ExpectedException( typeof( MessageTypeException ) )]
		public void TestUnpackInt16_ByteArray_UInt16MaxValueAsInt64_AsIs()
		{
			var result = Unpacking.UnpackInt16( new byte[] { 0xD3, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0xFF, 0xFF } );
		}
		
		[Test]
		[ExpectedException( typeof( MessageTypeException ) )]
		public void TestUnpackInt16_Stream_UInt16MaxValueAsInt64_AsIs()
		{
			using ( var buffer = new MemoryStream( new byte[] { 0xD3, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0xFF, 0xFF } ) )
			{
				var result = Unpacking.UnpackInt16( buffer );
			}
		}
		
		[Test]
		[ExpectedException( typeof( MessageTypeException ) )]
		public void TestUnpackInt16_ByteArray_UInt16MaxValueAsUInt64_AsIs()
		{
			var result = Unpacking.UnpackInt16( new byte[] { 0xCF, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0xFF, 0xFF } );
		}
		
		[Test]
		[ExpectedException( typeof( MessageTypeException ) )]
		public void TestUnpackInt16_Stream_UInt16MaxValueAsUInt64_AsIs()
		{
			using ( var buffer = new MemoryStream( new byte[] { 0xCF, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0xFF, 0xFF } ) )
			{
				var result = Unpacking.UnpackInt16( buffer );
			}
		}
		
		[Test]
		[ExpectedException( typeof( MessageTypeException ) )]
		public void TestUnpackInt16_ByteArray_UInt16MaxValueAsInt32_AsIs()
		{
			var result = Unpacking.UnpackInt16( new byte[] { 0xD2, 0x00, 0x00, 0xFF, 0xFF } );
		}
		
		[Test]
		[ExpectedException( typeof( MessageTypeException ) )]
		public void TestUnpackInt16_Stream_UInt16MaxValueAsInt32_AsIs()
		{
			using ( var buffer = new MemoryStream( new byte[] { 0xD2, 0x00, 0x00, 0xFF, 0xFF } ) )
			{
				var result = Unpacking.UnpackInt16( buffer );
			}
		}
		
		[Test]
		[ExpectedException( typeof( MessageTypeException ) )]
		public void TestUnpackInt16_ByteArray_UInt16MaxValueAsUInt32_AsIs()
		{
			var result = Unpacking.UnpackInt16( new byte[] { 0xCE, 0x00, 0x00, 0xFF, 0xFF } );
		}
		
		[Test]
		[ExpectedException( typeof( MessageTypeException ) )]
		public void TestUnpackInt16_Stream_UInt16MaxValueAsUInt32_AsIs()
		{
			using ( var buffer = new MemoryStream( new byte[] { 0xCE, 0x00, 0x00, 0xFF, 0xFF } ) )
			{
				var result = Unpacking.UnpackInt16( buffer );
			}
		}
		
		[Test]
		[ExpectedException( typeof( MessageTypeException ) )]
		public void TestUnpackInt16_ByteArray_UInt16MaxValueAsUInt16_AsIs()
		{
			var result = Unpacking.UnpackInt16( new byte[] { 0xCD, 0xFF, 0xFF } );
		}
		
		[Test]
		[ExpectedException( typeof( MessageTypeException ) )]
		public void TestUnpackInt16_Stream_UInt16MaxValueAsUInt16_AsIs()
		{
			using ( var buffer = new MemoryStream( new byte[] { 0xCD, 0xFF, 0xFF } ) )
			{
				var result = Unpacking.UnpackInt16( buffer );
			}
		}
		
		[Test]
		[ExpectedException( typeof( MessageTypeException ) )]
		public void TestUnpackInt16_ByteArray_UInt16MaxValuePlusOneAsInt64_AsIs()
		{
			var result = Unpacking.UnpackInt16( new byte[] { 0xD3, 0x00, 0x00, 0x00, 0x00, 0x00, 0x01, 0x00, 0x00 } );
		}
		
		[Test]
		[ExpectedException( typeof( MessageTypeException ) )]
		public void TestUnpackInt16_Stream_UInt16MaxValuePlusOneAsInt64_AsIs()
		{
			using ( var buffer = new MemoryStream( new byte[] { 0xD3, 0x00, 0x00, 0x00, 0x00, 0x00, 0x01, 0x00, 0x00 } ) )
			{
				var result = Unpacking.UnpackInt16( buffer );
			}
		}
		
		[Test]
		[ExpectedException( typeof( MessageTypeException ) )]
		public void TestUnpackInt16_ByteArray_UInt16MaxValuePlusOneAsUInt64_AsIs()
		{
			var result = Unpacking.UnpackInt16( new byte[] { 0xCF, 0x00, 0x00, 0x00, 0x00, 0x00, 0x01, 0x00, 0x00 } );
		}
		
		[Test]
		[ExpectedException( typeof( MessageTypeException ) )]
		public void TestUnpackInt16_Stream_UInt16MaxValuePlusOneAsUInt64_AsIs()
		{
			using ( var buffer = new MemoryStream( new byte[] { 0xCF, 0x00, 0x00, 0x00, 0x00, 0x00, 0x01, 0x00, 0x00 } ) )
			{
				var result = Unpacking.UnpackInt16( buffer );
			}
		}
		
		[Test]
		[ExpectedException( typeof( MessageTypeException ) )]
		public void TestUnpackInt16_ByteArray_UInt16MaxValuePlusOneAsInt32_AsIs()
		{
			var result = Unpacking.UnpackInt16( new byte[] { 0xD2, 0x00, 0x01, 0x00, 0x00 } );
		}
		
		[Test]
		[ExpectedException( typeof( MessageTypeException ) )]
		public void TestUnpackInt16_Stream_UInt16MaxValuePlusOneAsInt32_AsIs()
		{
			using ( var buffer = new MemoryStream( new byte[] { 0xD2, 0x00, 0x01, 0x00, 0x00 } ) )
			{
				var result = Unpacking.UnpackInt16( buffer );
			}
		}
		
		[Test]
		[ExpectedException( typeof( MessageTypeException ) )]
		public void TestUnpackInt16_ByteArray_UInt16MaxValuePlusOneAsUInt32_AsIs()
		{
			var result = Unpacking.UnpackInt16( new byte[] { 0xCE, 0x00, 0x01, 0x00, 0x00 } );
		}
		
		[Test]
		[ExpectedException( typeof( MessageTypeException ) )]
		public void TestUnpackInt16_Stream_UInt16MaxValuePlusOneAsUInt32_AsIs()
		{
			using ( var buffer = new MemoryStream( new byte[] { 0xCE, 0x00, 0x01, 0x00, 0x00 } ) )
			{
				var result = Unpacking.UnpackInt16( buffer );
			}
		}
		
		[Test]
		[ExpectedException( typeof( MessageTypeException ) )]
		public void TestUnpackInt16_ByteArray_UInt32MaxValueAsInt64_AsIs()
		{
			var result = Unpacking.UnpackInt16( new byte[] { 0xD3, 0x00, 0x00, 0x00, 0x00, 0xFF, 0xFF, 0xFF, 0xFF } );
		}
		
		[Test]
		[ExpectedException( typeof( MessageTypeException ) )]
		public void TestUnpackInt16_Stream_UInt32MaxValueAsInt64_AsIs()
		{
			using ( var buffer = new MemoryStream( new byte[] { 0xD3, 0x00, 0x00, 0x00, 0x00, 0xFF, 0xFF, 0xFF, 0xFF } ) )
			{
				var result = Unpacking.UnpackInt16( buffer );
			}
		}
		
		[Test]
		[ExpectedException( typeof( MessageTypeException ) )]
		public void TestUnpackInt16_ByteArray_UInt32MaxValueAsUInt64_AsIs()
		{
			var result = Unpacking.UnpackInt16( new byte[] { 0xCF, 0x00, 0x00, 0x00, 0x00, 0xFF, 0xFF, 0xFF, 0xFF } );
		}
		
		[Test]
		[ExpectedException( typeof( MessageTypeException ) )]
		public void TestUnpackInt16_Stream_UInt32MaxValueAsUInt64_AsIs()
		{
			using ( var buffer = new MemoryStream( new byte[] { 0xCF, 0x00, 0x00, 0x00, 0x00, 0xFF, 0xFF, 0xFF, 0xFF } ) )
			{
				var result = Unpacking.UnpackInt16( buffer );
			}
		}
		
		[Test]
		[ExpectedException( typeof( MessageTypeException ) )]
		public void TestUnpackInt16_ByteArray_UInt32MaxValueAsUInt32_AsIs()
		{
			var result = Unpacking.UnpackInt16( new byte[] { 0xCE, 0xFF, 0xFF, 0xFF, 0xFF } );
		}
		
		[Test]
		[ExpectedException( typeof( MessageTypeException ) )]
		public void TestUnpackInt16_Stream_UInt32MaxValueAsUInt32_AsIs()
		{
			using ( var buffer = new MemoryStream( new byte[] { 0xCE, 0xFF, 0xFF, 0xFF, 0xFF } ) )
			{
				var result = Unpacking.UnpackInt16( buffer );
			}
		}
		
		[Test]
		[ExpectedException( typeof( MessageTypeException ) )]
		public void TestUnpackInt16_ByteArray_UInt32MaxValuePlusOneAsInt64_AsIs()
		{
			var result = Unpacking.UnpackInt16( new byte[] { 0xD3, 0x00, 0x00, 0x00, 0x01, 0x00, 0x00, 0x00, 0x00 } );
		}
		
		[Test]
		[ExpectedException( typeof( MessageTypeException ) )]
		public void TestUnpackInt16_Stream_UInt32MaxValuePlusOneAsInt64_AsIs()
		{
			using ( var buffer = new MemoryStream( new byte[] { 0xD3, 0x00, 0x00, 0x00, 0x01, 0x00, 0x00, 0x00, 0x00 } ) )
			{
				var result = Unpacking.UnpackInt16( buffer );
			}
		}
		
		[Test]
		[ExpectedException( typeof( MessageTypeException ) )]
		public void TestUnpackInt16_ByteArray_UInt32MaxValuePlusOneAsUInt64_AsIs()
		{
			var result = Unpacking.UnpackInt16( new byte[] { 0xCF, 0x00, 0x00, 0x00, 0x01, 0x00, 0x00, 0x00, 0x00 } );
		}
		
		[Test]
		[ExpectedException( typeof( MessageTypeException ) )]
		public void TestUnpackInt16_Stream_UInt32MaxValuePlusOneAsUInt64_AsIs()
		{
			using ( var buffer = new MemoryStream( new byte[] { 0xCF, 0x00, 0x00, 0x00, 0x01, 0x00, 0x00, 0x00, 0x00 } ) )
			{
				var result = Unpacking.UnpackInt16( buffer );
			}
		}
		
		[Test]
		[ExpectedException( typeof( MessageTypeException ) )]
		public void TestUnpackInt16_ByteArray_UInt64MaxValueAsUInt64_AsIs()
		{
			var result = Unpacking.UnpackInt16( new byte[] { 0xCF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF } );
		}
		
		[Test]
		[ExpectedException( typeof( MessageTypeException ) )]
		public void TestUnpackInt16_Stream_UInt64MaxValueAsUInt64_AsIs()
		{
			using ( var buffer = new MemoryStream( new byte[] { 0xCF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF } ) )
			{
				var result = Unpacking.UnpackInt16( buffer );
			}
		}
		
		[Test]
		[ExpectedException( typeof( ArgumentException ) )]
		public void TestUnpackInt16_ByteArray_Empty()
		{
			Unpacking.UnpackInt16( new byte[ 0 ] );
		}

		[Test]
		[ExpectedException( typeof( ArgumentNullException ) )]
		public void TestUnpackInt16_ByteArray_Null()
		{
			Unpacking.UnpackInt16( default( byte[] ) );
		}

		[Test]
		[ExpectedException( typeof( ArgumentNullException ) )]
		public void TestUnpackInt16_ByteArray_Offset_Null()
		{
			Unpacking.UnpackInt16( default( byte[] ), 0 );
		}

		[Test]
		[ExpectedException( typeof( ArgumentOutOfRangeException ) )]
		public void TestUnpackInt16_ByteArray_Offset_OffsetIsNegative()
		{
			Unpacking.UnpackInt16( new byte[]{ 0x1 }, -1 );
		}

		[Test]
		[ExpectedException( typeof( ArgumentException ) )]
		public void TestUnpackInt16_ByteArray_Offset_OffsetIsTooBig()
		{
			Unpacking.UnpackInt16( new byte[]{ 0x1 }, 1 );
		}

		[Test]
		[ExpectedException( typeof( ArgumentException ) )]
		public void TestUnpackInt16_ByteArray_Offset_Empty()
		{
			Unpacking.UnpackInt16( new byte[ 0 ], 0 );
		}

		[Test]
		[ExpectedException( typeof( ArgumentNullException ) )]
		public void TestUnpackInt16_Stream_Null()
		{
			Unpacking.UnpackInt16( default( Stream ) );
		}

		[Test]
		public void TestUnpackInt16_ByteArray_Offset_OffsetIsValid_OffsetIsRespected()
		{
			// Offset 1 is positive fix num 1.
			var result = Unpacking.UnpackInt16( new byte[] { 0xFF, 0x57, 0xFF }, 1 );
			Assert.AreEqual( 1, result.ReadCount );
			Assert.AreEqual( 0x57, result.Value );
		}

		[Test]
		[ExpectedException( typeof( MessageTypeException ) )]
		public void TestUnpackInt16_ByteArray_Null_Nil()
		{
			Unpacking.UnpackInt16( new byte[] { 0xC0 } );
		}
	
		[Test]
		[ExpectedException( typeof( MessageTypeException ) )]
		public void TestUnpackInt16_ByteArray_NotInt16()
		{
			Unpacking.UnpackInt16( new byte[] { 0xA0 } );
		}
	}

	partial class UnpackingTest_Combinations_UInt16
	{
		[Test]
		[ExpectedException( typeof( MessageTypeException ) )]
		public void TestUnpackUInt16_ByteArray_Int64MinValueAsInt64_AsIs()
		{
			var result = Unpacking.UnpackUInt16( new byte[] { 0xD3, 0x80, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 } );
		}
		
		[Test]
		[ExpectedException( typeof( MessageTypeException ) )]
		public void TestUnpackUInt16_Stream_Int64MinValueAsInt64_AsIs()
		{
			using ( var buffer = new MemoryStream( new byte[] { 0xD3, 0x80, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 } ) )
			{
				var result = Unpacking.UnpackUInt16( buffer );
			}
		}
		
		[Test]
		[ExpectedException( typeof( MessageTypeException ) )]
		public void TestUnpackUInt16_ByteArray_Int32MinValueMinusOneAsInt64_AsIs()
		{
			var result = Unpacking.UnpackUInt16( new byte[] { 0xD3, 0xFF, 0xFF, 0xFF, 0xFF, 0x7F, 0xFF, 0xFF, 0xFF } );
		}
		
		[Test]
		[ExpectedException( typeof( MessageTypeException ) )]
		public void TestUnpackUInt16_Stream_Int32MinValueMinusOneAsInt64_AsIs()
		{
			using ( var buffer = new MemoryStream( new byte[] { 0xD3, 0xFF, 0xFF, 0xFF, 0xFF, 0x7F, 0xFF, 0xFF, 0xFF } ) )
			{
				var result = Unpacking.UnpackUInt16( buffer );
			}
		}
		
		[Test]
		[ExpectedException( typeof( MessageTypeException ) )]
		public void TestUnpackUInt16_ByteArray_Int32MinValueAsInt64_AsIs()
		{
			var result = Unpacking.UnpackUInt16( new byte[] { 0xD3, 0xFF, 0xFF, 0xFF, 0xFF, 0x80, 0x00, 0x00, 0x00 } );
		}
		
		[Test]
		[ExpectedException( typeof( MessageTypeException ) )]
		public void TestUnpackUInt16_Stream_Int32MinValueAsInt64_AsIs()
		{
			using ( var buffer = new MemoryStream( new byte[] { 0xD3, 0xFF, 0xFF, 0xFF, 0xFF, 0x80, 0x00, 0x00, 0x00 } ) )
			{
				var result = Unpacking.UnpackUInt16( buffer );
			}
		}
		
		[Test]
		[ExpectedException( typeof( MessageTypeException ) )]
		public void TestUnpackUInt16_ByteArray_Int32MinValueAsInt32_AsIs()
		{
			var result = Unpacking.UnpackUInt16( new byte[] { 0xD2, 0x80, 0x00, 0x00, 0x00 } );
		}
		
		[Test]
		[ExpectedException( typeof( MessageTypeException ) )]
		public void TestUnpackUInt16_Stream_Int32MinValueAsInt32_AsIs()
		{
			using ( var buffer = new MemoryStream( new byte[] { 0xD2, 0x80, 0x00, 0x00, 0x00 } ) )
			{
				var result = Unpacking.UnpackUInt16( buffer );
			}
		}
		
		[Test]
		[ExpectedException( typeof( MessageTypeException ) )]
		public void TestUnpackUInt16_ByteArray_Int16MinValueMinusOneAsInt64_AsIs()
		{
			var result = Unpacking.UnpackUInt16( new byte[] { 0xD3, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0x7F, 0xFF } );
		}
		
		[Test]
		[ExpectedException( typeof( MessageTypeException ) )]
		public void TestUnpackUInt16_Stream_Int16MinValueMinusOneAsInt64_AsIs()
		{
			using ( var buffer = new MemoryStream( new byte[] { 0xD3, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0x7F, 0xFF } ) )
			{
				var result = Unpacking.UnpackUInt16( buffer );
			}
		}
		
		[Test]
		[ExpectedException( typeof( MessageTypeException ) )]
		public void TestUnpackUInt16_ByteArray_Int16MinValueMinusOneAsInt32_AsIs()
		{
			var result = Unpacking.UnpackUInt16( new byte[] { 0xD2, 0xFF, 0xFF, 0x7F, 0xFF } );
		}
		
		[Test]
		[ExpectedException( typeof( MessageTypeException ) )]
		public void TestUnpackUInt16_Stream_Int16MinValueMinusOneAsInt32_AsIs()
		{
			using ( var buffer = new MemoryStream( new byte[] { 0xD2, 0xFF, 0xFF, 0x7F, 0xFF } ) )
			{
				var result = Unpacking.UnpackUInt16( buffer );
			}
		}
		
		[Test]
		[ExpectedException( typeof( MessageTypeException ) )]
		public void TestUnpackUInt16_ByteArray_Int16MinValueAsInt64_AsIs()
		{
			var result = Unpacking.UnpackUInt16( new byte[] { 0xD3, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0x80, 0x00 } );
		}
		
		[Test]
		[ExpectedException( typeof( MessageTypeException ) )]
		public void TestUnpackUInt16_Stream_Int16MinValueAsInt64_AsIs()
		{
			using ( var buffer = new MemoryStream( new byte[] { 0xD3, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0x80, 0x00 } ) )
			{
				var result = Unpacking.UnpackUInt16( buffer );
			}
		}
		
		[Test]
		[ExpectedException( typeof( MessageTypeException ) )]
		public void TestUnpackUInt16_ByteArray_Int16MinValueAsInt32_AsIs()
		{
			var result = Unpacking.UnpackUInt16( new byte[] { 0xD2, 0xFF, 0xFF, 0x80, 0x00 } );
		}
		
		[Test]
		[ExpectedException( typeof( MessageTypeException ) )]
		public void TestUnpackUInt16_Stream_Int16MinValueAsInt32_AsIs()
		{
			using ( var buffer = new MemoryStream( new byte[] { 0xD2, 0xFF, 0xFF, 0x80, 0x00 } ) )
			{
				var result = Unpacking.UnpackUInt16( buffer );
			}
		}
		
		[Test]
		[ExpectedException( typeof( MessageTypeException ) )]
		public void TestUnpackUInt16_ByteArray_Int16MinValueAsInt16_AsIs()
		{
			var result = Unpacking.UnpackUInt16( new byte[] { 0xD1, 0x80, 0x00 } );
		}
		
		[Test]
		[ExpectedException( typeof( MessageTypeException ) )]
		public void TestUnpackUInt16_Stream_Int16MinValueAsInt16_AsIs()
		{
			using ( var buffer = new MemoryStream( new byte[] { 0xD1, 0x80, 0x00 } ) )
			{
				var result = Unpacking.UnpackUInt16( buffer );
			}
		}
		
		[Test]
		[ExpectedException( typeof( MessageTypeException ) )]
		public void TestUnpackUInt16_ByteArray_SByteMinValueMinusOneAsInt64_AsIs()
		{
			var result = Unpacking.UnpackUInt16( new byte[] { 0xD3, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0x7F } );
		}
		
		[Test]
		[ExpectedException( typeof( MessageTypeException ) )]
		public void TestUnpackUInt16_Stream_SByteMinValueMinusOneAsInt64_AsIs()
		{
			using ( var buffer = new MemoryStream( new byte[] { 0xD3, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0x7F } ) )
			{
				var result = Unpacking.UnpackUInt16( buffer );
			}
		}
		
		[Test]
		[ExpectedException( typeof( MessageTypeException ) )]
		public void TestUnpackUInt16_ByteArray_SByteMinValueMinusOneAsInt32_AsIs()
		{
			var result = Unpacking.UnpackUInt16( new byte[] { 0xD2, 0xFF, 0xFF, 0xFF, 0x7F } );
		}
		
		[Test]
		[ExpectedException( typeof( MessageTypeException ) )]
		public void TestUnpackUInt16_Stream_SByteMinValueMinusOneAsInt32_AsIs()
		{
			using ( var buffer = new MemoryStream( new byte[] { 0xD2, 0xFF, 0xFF, 0xFF, 0x7F } ) )
			{
				var result = Unpacking.UnpackUInt16( buffer );
			}
		}
		
		[Test]
		[ExpectedException( typeof( MessageTypeException ) )]
		public void TestUnpackUInt16_ByteArray_SByteMinValueMinusOneAsInt16_AsIs()
		{
			var result = Unpacking.UnpackUInt16( new byte[] { 0xD1, 0xFF, 0x7F } );
		}
		
		[Test]
		[ExpectedException( typeof( MessageTypeException ) )]
		public void TestUnpackUInt16_Stream_SByteMinValueMinusOneAsInt16_AsIs()
		{
			using ( var buffer = new MemoryStream( new byte[] { 0xD1, 0xFF, 0x7F } ) )
			{
				var result = Unpacking.UnpackUInt16( buffer );
			}
		}
		
		[Test]
		[ExpectedException( typeof( MessageTypeException ) )]
		public void TestUnpackUInt16_ByteArray_SByteMinValueAsInt64_AsIs()
		{
			var result = Unpacking.UnpackUInt16( new byte[] { 0xD3, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0x80 } );
		}
		
		[Test]
		[ExpectedException( typeof( MessageTypeException ) )]
		public void TestUnpackUInt16_Stream_SByteMinValueAsInt64_AsIs()
		{
			using ( var buffer = new MemoryStream( new byte[] { 0xD3, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0x80 } ) )
			{
				var result = Unpacking.UnpackUInt16( buffer );
			}
		}
		
		[Test]
		[ExpectedException( typeof( MessageTypeException ) )]
		public void TestUnpackUInt16_ByteArray_SByteMinValueAsInt32_AsIs()
		{
			var result = Unpacking.UnpackUInt16( new byte[] { 0xD2, 0xFF, 0xFF, 0xFF, 0x80 } );
		}
		
		[Test]
		[ExpectedException( typeof( MessageTypeException ) )]
		public void TestUnpackUInt16_Stream_SByteMinValueAsInt32_AsIs()
		{
			using ( var buffer = new MemoryStream( new byte[] { 0xD2, 0xFF, 0xFF, 0xFF, 0x80 } ) )
			{
				var result = Unpacking.UnpackUInt16( buffer );
			}
		}
		
		[Test]
		[ExpectedException( typeof( MessageTypeException ) )]
		public void TestUnpackUInt16_ByteArray_SByteMinValueAsInt16_AsIs()
		{
			var result = Unpacking.UnpackUInt16( new byte[] { 0xD1, 0xFF, 0x80 } );
		}
		
		[Test]
		[ExpectedException( typeof( MessageTypeException ) )]
		public void TestUnpackUInt16_Stream_SByteMinValueAsInt16_AsIs()
		{
			using ( var buffer = new MemoryStream( new byte[] { 0xD1, 0xFF, 0x80 } ) )
			{
				var result = Unpacking.UnpackUInt16( buffer );
			}
		}
		
		[Test]
		[ExpectedException( typeof( MessageTypeException ) )]
		public void TestUnpackUInt16_ByteArray_SByteMinValueAsInt8_AsIs()
		{
			var result = Unpacking.UnpackUInt16( new byte[] { 0xD0, 0x80 } );
		}
		
		[Test]
		[ExpectedException( typeof( MessageTypeException ) )]
		public void TestUnpackUInt16_Stream_SByteMinValueAsInt8_AsIs()
		{
			using ( var buffer = new MemoryStream( new byte[] { 0xD0, 0x80 } ) )
			{
				var result = Unpacking.UnpackUInt16( buffer );
			}
		}
		
		[Test]
		[ExpectedException( typeof( MessageTypeException ) )]
		public void TestUnpackUInt16_ByteArray_NegativeFixNumMinValueMinusOneAsInt64_AsIs()
		{
			var result = Unpacking.UnpackUInt16( new byte[] { 0xD3, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xDF } );
		}
		
		[Test]
		[ExpectedException( typeof( MessageTypeException ) )]
		public void TestUnpackUInt16_Stream_NegativeFixNumMinValueMinusOneAsInt64_AsIs()
		{
			using ( var buffer = new MemoryStream( new byte[] { 0xD3, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xDF } ) )
			{
				var result = Unpacking.UnpackUInt16( buffer );
			}
		}
		
		[Test]
		[ExpectedException( typeof( MessageTypeException ) )]
		public void TestUnpackUInt16_ByteArray_NegativeFixNumMinValueMinusOneAsInt32_AsIs()
		{
			var result = Unpacking.UnpackUInt16( new byte[] { 0xD2, 0xFF, 0xFF, 0xFF, 0xDF } );
		}
		
		[Test]
		[ExpectedException( typeof( MessageTypeException ) )]
		public void TestUnpackUInt16_Stream_NegativeFixNumMinValueMinusOneAsInt32_AsIs()
		{
			using ( var buffer = new MemoryStream( new byte[] { 0xD2, 0xFF, 0xFF, 0xFF, 0xDF } ) )
			{
				var result = Unpacking.UnpackUInt16( buffer );
			}
		}
		
		[Test]
		[ExpectedException( typeof( MessageTypeException ) )]
		public void TestUnpackUInt16_ByteArray_NegativeFixNumMinValueMinusOneAsInt16_AsIs()
		{
			var result = Unpacking.UnpackUInt16( new byte[] { 0xD1, 0xFF, 0xDF } );
		}
		
		[Test]
		[ExpectedException( typeof( MessageTypeException ) )]
		public void TestUnpackUInt16_Stream_NegativeFixNumMinValueMinusOneAsInt16_AsIs()
		{
			using ( var buffer = new MemoryStream( new byte[] { 0xD1, 0xFF, 0xDF } ) )
			{
				var result = Unpacking.UnpackUInt16( buffer );
			}
		}
		
		[Test]
		[ExpectedException( typeof( MessageTypeException ) )]
		public void TestUnpackUInt16_ByteArray_NegativeFixNumMinValueMinusOneAsInt8_AsIs()
		{
			var result = Unpacking.UnpackUInt16( new byte[] { 0xD0, 0xDF } );
		}
		
		[Test]
		[ExpectedException( typeof( MessageTypeException ) )]
		public void TestUnpackUInt16_Stream_NegativeFixNumMinValueMinusOneAsInt8_AsIs()
		{
			using ( var buffer = new MemoryStream( new byte[] { 0xD0, 0xDF } ) )
			{
				var result = Unpacking.UnpackUInt16( buffer );
			}
		}
		
		[Test]
		[ExpectedException( typeof( MessageTypeException ) )]
		public void TestUnpackUInt16_ByteArray_NegativeFixNumMinValueAsInt64_AsIs()
		{
			var result = Unpacking.UnpackUInt16( new byte[] { 0xD3, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xE0 } );
		}
		
		[Test]
		[ExpectedException( typeof( MessageTypeException ) )]
		public void TestUnpackUInt16_Stream_NegativeFixNumMinValueAsInt64_AsIs()
		{
			using ( var buffer = new MemoryStream( new byte[] { 0xD3, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xE0 } ) )
			{
				var result = Unpacking.UnpackUInt16( buffer );
			}
		}
		
		[Test]
		[ExpectedException( typeof( MessageTypeException ) )]
		public void TestUnpackUInt16_ByteArray_NegativeFixNumMinValueAsInt32_AsIs()
		{
			var result = Unpacking.UnpackUInt16( new byte[] { 0xD2, 0xFF, 0xFF, 0xFF, 0xE0 } );
		}
		
		[Test]
		[ExpectedException( typeof( MessageTypeException ) )]
		public void TestUnpackUInt16_Stream_NegativeFixNumMinValueAsInt32_AsIs()
		{
			using ( var buffer = new MemoryStream( new byte[] { 0xD2, 0xFF, 0xFF, 0xFF, 0xE0 } ) )
			{
				var result = Unpacking.UnpackUInt16( buffer );
			}
		}
		
		[Test]
		[ExpectedException( typeof( MessageTypeException ) )]
		public void TestUnpackUInt16_ByteArray_NegativeFixNumMinValueAsInt16_AsIs()
		{
			var result = Unpacking.UnpackUInt16( new byte[] { 0xD1, 0xFF, 0xE0 } );
		}
		
		[Test]
		[ExpectedException( typeof( MessageTypeException ) )]
		public void TestUnpackUInt16_Stream_NegativeFixNumMinValueAsInt16_AsIs()
		{
			using ( var buffer = new MemoryStream( new byte[] { 0xD1, 0xFF, 0xE0 } ) )
			{
				var result = Unpacking.UnpackUInt16( buffer );
			}
		}
		
		[Test]
		[ExpectedException( typeof( MessageTypeException ) )]
		public void TestUnpackUInt16_ByteArray_NegativeFixNumMinValueAsInt8_AsIs()
		{
			var result = Unpacking.UnpackUInt16( new byte[] { 0xD0, 0xE0 } );
		}
		
		[Test]
		[ExpectedException( typeof( MessageTypeException ) )]
		public void TestUnpackUInt16_Stream_NegativeFixNumMinValueAsInt8_AsIs()
		{
			using ( var buffer = new MemoryStream( new byte[] { 0xD0, 0xE0 } ) )
			{
				var result = Unpacking.UnpackUInt16( buffer );
			}
		}
		
		[Test]
		[ExpectedException( typeof( MessageTypeException ) )]
		public void TestUnpackUInt16_ByteArray_NegativeFixNumMinValueAsNegativeFixNumMinus32_AsIs()
		{
			var result = Unpacking.UnpackUInt16( new byte[] { 0xE0 } );
		}
		
		[Test]
		[ExpectedException( typeof( MessageTypeException ) )]
		public void TestUnpackUInt16_Stream_NegativeFixNumMinValueAsNegativeFixNumMinus32_AsIs()
		{
			using ( var buffer = new MemoryStream( new byte[] { 0xE0 } ) )
			{
				var result = Unpacking.UnpackUInt16( buffer );
			}
		}
		
		[Test]
		[ExpectedException( typeof( MessageTypeException ) )]
		public void TestUnpackUInt16_ByteArray_MinusOneAsInt64_AsIs()
		{
			var result = Unpacking.UnpackUInt16( new byte[] { 0xD3, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF } );
		}
		
		[Test]
		[ExpectedException( typeof( MessageTypeException ) )]
		public void TestUnpackUInt16_Stream_MinusOneAsInt64_AsIs()
		{
			using ( var buffer = new MemoryStream( new byte[] { 0xD3, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF } ) )
			{
				var result = Unpacking.UnpackUInt16( buffer );
			}
		}
		
		[Test]
		[ExpectedException( typeof( MessageTypeException ) )]
		public void TestUnpackUInt16_ByteArray_MinusOneAsInt32_AsIs()
		{
			var result = Unpacking.UnpackUInt16( new byte[] { 0xD2, 0xFF, 0xFF, 0xFF, 0xFF } );
		}
		
		[Test]
		[ExpectedException( typeof( MessageTypeException ) )]
		public void TestUnpackUInt16_Stream_MinusOneAsInt32_AsIs()
		{
			using ( var buffer = new MemoryStream( new byte[] { 0xD2, 0xFF, 0xFF, 0xFF, 0xFF } ) )
			{
				var result = Unpacking.UnpackUInt16( buffer );
			}
		}
		
		[Test]
		[ExpectedException( typeof( MessageTypeException ) )]
		public void TestUnpackUInt16_ByteArray_MinusOneAsInt16_AsIs()
		{
			var result = Unpacking.UnpackUInt16( new byte[] { 0xD1, 0xFF, 0xFF } );
		}
		
		[Test]
		[ExpectedException( typeof( MessageTypeException ) )]
		public void TestUnpackUInt16_Stream_MinusOneAsInt16_AsIs()
		{
			using ( var buffer = new MemoryStream( new byte[] { 0xD1, 0xFF, 0xFF } ) )
			{
				var result = Unpacking.UnpackUInt16( buffer );
			}
		}
		
		[Test]
		[ExpectedException( typeof( MessageTypeException ) )]
		public void TestUnpackUInt16_ByteArray_MinusOneAsInt8_AsIs()
		{
			var result = Unpacking.UnpackUInt16( new byte[] { 0xD0, 0xFF } );
		}
		
		[Test]
		[ExpectedException( typeof( MessageTypeException ) )]
		public void TestUnpackUInt16_Stream_MinusOneAsInt8_AsIs()
		{
			using ( var buffer = new MemoryStream( new byte[] { 0xD0, 0xFF } ) )
			{
				var result = Unpacking.UnpackUInt16( buffer );
			}
		}
		
		[Test]
		[ExpectedException( typeof( MessageTypeException ) )]
		public void TestUnpackUInt16_ByteArray_MinusOneAsNegativeFixNumMinus1_AsIs()
		{
			var result = Unpacking.UnpackUInt16( new byte[] { 0xFF } );
		}
		
		[Test]
		[ExpectedException( typeof( MessageTypeException ) )]
		public void TestUnpackUInt16_Stream_MinusOneAsNegativeFixNumMinus1_AsIs()
		{
			using ( var buffer = new MemoryStream( new byte[] { 0xFF } ) )
			{
				var result = Unpacking.UnpackUInt16( buffer );
			}
		}
		
		[Test]
		public void TestUnpackUInt16_ByteArray_ZeroAsInt64_Fail()
		{
			var result = Unpacking.UnpackUInt16( new byte[] { 0xD3, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 } );
			Assert.AreEqual( 9, result.ReadCount );
			Assert.AreEqual( 0L, result.Value );
		}
		
		[Test]
		public void TestUnpackUInt16_Stream_ZeroAsInt64_Fail()
		{
			using ( var buffer = new MemoryStream( new byte[] { 0xD3, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 } ) )
			{
				var result = Unpacking.UnpackUInt16( buffer );
				Assert.AreEqual( 9, buffer.Position );
				Assert.AreEqual( 0L, result );
			}
		}
		
		[Test]
		public void TestUnpackUInt16_ByteArray_ZeroAsUInt64_Fail()
		{
			var result = Unpacking.UnpackUInt16( new byte[] { 0xCF, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 } );
			Assert.AreEqual( 9, result.ReadCount );
			Assert.AreEqual( 0L, result.Value );
		}
		
		[Test]
		public void TestUnpackUInt16_Stream_ZeroAsUInt64_Fail()
		{
			using ( var buffer = new MemoryStream( new byte[] { 0xCF, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 } ) )
			{
				var result = Unpacking.UnpackUInt16( buffer );
				Assert.AreEqual( 9, buffer.Position );
				Assert.AreEqual( 0L, result );
			}
		}
		
		[Test]
		public void TestUnpackUInt16_ByteArray_ZeroAsInt32_Fail()
		{
			var result = Unpacking.UnpackUInt16( new byte[] { 0xD2, 0x00, 0x00, 0x00, 0x00 } );
			Assert.AreEqual( 5, result.ReadCount );
			Assert.AreEqual( 0L, result.Value );
		}
		
		[Test]
		public void TestUnpackUInt16_Stream_ZeroAsInt32_Fail()
		{
			using ( var buffer = new MemoryStream( new byte[] { 0xD2, 0x00, 0x00, 0x00, 0x00 } ) )
			{
				var result = Unpacking.UnpackUInt16( buffer );
				Assert.AreEqual( 5, buffer.Position );
				Assert.AreEqual( 0L, result );
			}
		}
		
		[Test]
		public void TestUnpackUInt16_ByteArray_ZeroAsUInt32_Fail()
		{
			var result = Unpacking.UnpackUInt16( new byte[] { 0xCE, 0x00, 0x00, 0x00, 0x00 } );
			Assert.AreEqual( 5, result.ReadCount );
			Assert.AreEqual( 0L, result.Value );
		}
		
		[Test]
		public void TestUnpackUInt16_Stream_ZeroAsUInt32_Fail()
		{
			using ( var buffer = new MemoryStream( new byte[] { 0xCE, 0x00, 0x00, 0x00, 0x00 } ) )
			{
				var result = Unpacking.UnpackUInt16( buffer );
				Assert.AreEqual( 5, buffer.Position );
				Assert.AreEqual( 0L, result );
			}
		}
		
		[Test]
		public void TestUnpackUInt16_ByteArray_ZeroAsInt16_Fail()
		{
			var result = Unpacking.UnpackUInt16( new byte[] { 0xD1, 0x00, 0x00 } );
			Assert.AreEqual( 3, result.ReadCount );
			Assert.AreEqual( 0L, result.Value );
		}
		
		[Test]
		public void TestUnpackUInt16_Stream_ZeroAsInt16_Fail()
		{
			using ( var buffer = new MemoryStream( new byte[] { 0xD1, 0x00, 0x00 } ) )
			{
				var result = Unpacking.UnpackUInt16( buffer );
				Assert.AreEqual( 3, buffer.Position );
				Assert.AreEqual( 0L, result );
			}
		}
		
		[Test]
		public void TestUnpackUInt16_ByteArray_ZeroAsUInt16_Fail()
		{
			var result = Unpacking.UnpackUInt16( new byte[] { 0xCD, 0x00, 0x00 } );
			Assert.AreEqual( 3, result.ReadCount );
			Assert.AreEqual( 0L, result.Value );
		}
		
		[Test]
		public void TestUnpackUInt16_Stream_ZeroAsUInt16_Fail()
		{
			using ( var buffer = new MemoryStream( new byte[] { 0xCD, 0x00, 0x00 } ) )
			{
				var result = Unpacking.UnpackUInt16( buffer );
				Assert.AreEqual( 3, buffer.Position );
				Assert.AreEqual( 0L, result );
			}
		}
		
		[Test]
		public void TestUnpackUInt16_ByteArray_ZeroAsInt8_Fail()
		{
			var result = Unpacking.UnpackUInt16( new byte[] { 0xD0, 0x00 } );
			Assert.AreEqual( 2, result.ReadCount );
			Assert.AreEqual( 0L, result.Value );
		}
		
		[Test]
		public void TestUnpackUInt16_Stream_ZeroAsInt8_Fail()
		{
			using ( var buffer = new MemoryStream( new byte[] { 0xD0, 0x00 } ) )
			{
				var result = Unpacking.UnpackUInt16( buffer );
				Assert.AreEqual( 2, buffer.Position );
				Assert.AreEqual( 0L, result );
			}
		}
		
		[Test]
		public void TestUnpackUInt16_ByteArray_ZeroAsUInt8_Fail()
		{
			var result = Unpacking.UnpackUInt16( new byte[] { 0xCC, 0x00 } );
			Assert.AreEqual( 2, result.ReadCount );
			Assert.AreEqual( 0L, result.Value );
		}
		
		[Test]
		public void TestUnpackUInt16_Stream_ZeroAsUInt8_Fail()
		{
			using ( var buffer = new MemoryStream( new byte[] { 0xCC, 0x00 } ) )
			{
				var result = Unpacking.UnpackUInt16( buffer );
				Assert.AreEqual( 2, buffer.Position );
				Assert.AreEqual( 0L, result );
			}
		}
		
		[Test]
		public void TestUnpackUInt16_ByteArray_ZeroAsPositiveFixNum0_Fail()
		{
			var result = Unpacking.UnpackUInt16( new byte[] { 0x00 } );
			Assert.AreEqual( 1, result.ReadCount );
			Assert.AreEqual( 0L, result.Value );
		}
		
		[Test]
		public void TestUnpackUInt16_Stream_ZeroAsPositiveFixNum0_Fail()
		{
			using ( var buffer = new MemoryStream( new byte[] { 0x00 } ) )
			{
				var result = Unpacking.UnpackUInt16( buffer );
				Assert.AreEqual( 1, buffer.Position );
				Assert.AreEqual( 0L, result );
			}
		}
		
		[Test]
		public void TestUnpackUInt16_ByteArray_PlusOneAsInt64_Fail()
		{
			var result = Unpacking.UnpackUInt16( new byte[] { 0xD3, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x01 } );
			Assert.AreEqual( 9, result.ReadCount );
			Assert.AreEqual( 1L, result.Value );
		}
		
		[Test]
		public void TestUnpackUInt16_Stream_PlusOneAsInt64_Fail()
		{
			using ( var buffer = new MemoryStream( new byte[] { 0xD3, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x01 } ) )
			{
				var result = Unpacking.UnpackUInt16( buffer );
				Assert.AreEqual( 9, buffer.Position );
				Assert.AreEqual( 1L, result );
			}
		}
		
		[Test]
		public void TestUnpackUInt16_ByteArray_PlusOneAsUInt64_Fail()
		{
			var result = Unpacking.UnpackUInt16( new byte[] { 0xCF, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x01 } );
			Assert.AreEqual( 9, result.ReadCount );
			Assert.AreEqual( 1L, result.Value );
		}
		
		[Test]
		public void TestUnpackUInt16_Stream_PlusOneAsUInt64_Fail()
		{
			using ( var buffer = new MemoryStream( new byte[] { 0xCF, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x01 } ) )
			{
				var result = Unpacking.UnpackUInt16( buffer );
				Assert.AreEqual( 9, buffer.Position );
				Assert.AreEqual( 1L, result );
			}
		}
		
		[Test]
		public void TestUnpackUInt16_ByteArray_PlusOneAsInt32_Fail()
		{
			var result = Unpacking.UnpackUInt16( new byte[] { 0xD2, 0x00, 0x00, 0x00, 0x01 } );
			Assert.AreEqual( 5, result.ReadCount );
			Assert.AreEqual( 1L, result.Value );
		}
		
		[Test]
		public void TestUnpackUInt16_Stream_PlusOneAsInt32_Fail()
		{
			using ( var buffer = new MemoryStream( new byte[] { 0xD2, 0x00, 0x00, 0x00, 0x01 } ) )
			{
				var result = Unpacking.UnpackUInt16( buffer );
				Assert.AreEqual( 5, buffer.Position );
				Assert.AreEqual( 1L, result );
			}
		}
		
		[Test]
		public void TestUnpackUInt16_ByteArray_PlusOneAsUInt32_Fail()
		{
			var result = Unpacking.UnpackUInt16( new byte[] { 0xCE, 0x00, 0x00, 0x00, 0x01 } );
			Assert.AreEqual( 5, result.ReadCount );
			Assert.AreEqual( 1L, result.Value );
		}
		
		[Test]
		public void TestUnpackUInt16_Stream_PlusOneAsUInt32_Fail()
		{
			using ( var buffer = new MemoryStream( new byte[] { 0xCE, 0x00, 0x00, 0x00, 0x01 } ) )
			{
				var result = Unpacking.UnpackUInt16( buffer );
				Assert.AreEqual( 5, buffer.Position );
				Assert.AreEqual( 1L, result );
			}
		}
		
		[Test]
		public void TestUnpackUInt16_ByteArray_PlusOneAsInt16_Fail()
		{
			var result = Unpacking.UnpackUInt16( new byte[] { 0xD1, 0x00, 0x01 } );
			Assert.AreEqual( 3, result.ReadCount );
			Assert.AreEqual( 1L, result.Value );
		}
		
		[Test]
		public void TestUnpackUInt16_Stream_PlusOneAsInt16_Fail()
		{
			using ( var buffer = new MemoryStream( new byte[] { 0xD1, 0x00, 0x01 } ) )
			{
				var result = Unpacking.UnpackUInt16( buffer );
				Assert.AreEqual( 3, buffer.Position );
				Assert.AreEqual( 1L, result );
			}
		}
		
		[Test]
		public void TestUnpackUInt16_ByteArray_PlusOneAsUInt16_Fail()
		{
			var result = Unpacking.UnpackUInt16( new byte[] { 0xCD, 0x00, 0x01 } );
			Assert.AreEqual( 3, result.ReadCount );
			Assert.AreEqual( 1L, result.Value );
		}
		
		[Test]
		public void TestUnpackUInt16_Stream_PlusOneAsUInt16_Fail()
		{
			using ( var buffer = new MemoryStream( new byte[] { 0xCD, 0x00, 0x01 } ) )
			{
				var result = Unpacking.UnpackUInt16( buffer );
				Assert.AreEqual( 3, buffer.Position );
				Assert.AreEqual( 1L, result );
			}
		}
		
		[Test]
		public void TestUnpackUInt16_ByteArray_PlusOneAsInt8_Fail()
		{
			var result = Unpacking.UnpackUInt16( new byte[] { 0xD0, 0x01 } );
			Assert.AreEqual( 2, result.ReadCount );
			Assert.AreEqual( 1L, result.Value );
		}
		
		[Test]
		public void TestUnpackUInt16_Stream_PlusOneAsInt8_Fail()
		{
			using ( var buffer = new MemoryStream( new byte[] { 0xD0, 0x01 } ) )
			{
				var result = Unpacking.UnpackUInt16( buffer );
				Assert.AreEqual( 2, buffer.Position );
				Assert.AreEqual( 1L, result );
			}
		}
		
		[Test]
		public void TestUnpackUInt16_ByteArray_PlusOneAsUInt8_Fail()
		{
			var result = Unpacking.UnpackUInt16( new byte[] { 0xCC, 0x01 } );
			Assert.AreEqual( 2, result.ReadCount );
			Assert.AreEqual( 1L, result.Value );
		}
		
		[Test]
		public void TestUnpackUInt16_Stream_PlusOneAsUInt8_Fail()
		{
			using ( var buffer = new MemoryStream( new byte[] { 0xCC, 0x01 } ) )
			{
				var result = Unpacking.UnpackUInt16( buffer );
				Assert.AreEqual( 2, buffer.Position );
				Assert.AreEqual( 1L, result );
			}
		}
		
		[Test]
		public void TestUnpackUInt16_ByteArray_PlusOneAsPositiveFixNum1_Fail()
		{
			var result = Unpacking.UnpackUInt16( new byte[] { 0x01 } );
			Assert.AreEqual( 1, result.ReadCount );
			Assert.AreEqual( 1L, result.Value );
		}
		
		[Test]
		public void TestUnpackUInt16_Stream_PlusOneAsPositiveFixNum1_Fail()
		{
			using ( var buffer = new MemoryStream( new byte[] { 0x01 } ) )
			{
				var result = Unpacking.UnpackUInt16( buffer );
				Assert.AreEqual( 1, buffer.Position );
				Assert.AreEqual( 1L, result );
			}
		}
		
		[Test]
		public void TestUnpackUInt16_ByteArray_PositiveFixNumMaxValueAsInt64_Fail()
		{
			var result = Unpacking.UnpackUInt16( new byte[] { 0xD3, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x7F } );
			Assert.AreEqual( 9, result.ReadCount );
			Assert.AreEqual( 127L, result.Value );
		}
		
		[Test]
		public void TestUnpackUInt16_Stream_PositiveFixNumMaxValueAsInt64_Fail()
		{
			using ( var buffer = new MemoryStream( new byte[] { 0xD3, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x7F } ) )
			{
				var result = Unpacking.UnpackUInt16( buffer );
				Assert.AreEqual( 9, buffer.Position );
				Assert.AreEqual( 127L, result );
			}
		}
		
		[Test]
		public void TestUnpackUInt16_ByteArray_PositiveFixNumMaxValueAsUInt64_Fail()
		{
			var result = Unpacking.UnpackUInt16( new byte[] { 0xCF, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x7F } );
			Assert.AreEqual( 9, result.ReadCount );
			Assert.AreEqual( 127L, result.Value );
		}
		
		[Test]
		public void TestUnpackUInt16_Stream_PositiveFixNumMaxValueAsUInt64_Fail()
		{
			using ( var buffer = new MemoryStream( new byte[] { 0xCF, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x7F } ) )
			{
				var result = Unpacking.UnpackUInt16( buffer );
				Assert.AreEqual( 9, buffer.Position );
				Assert.AreEqual( 127L, result );
			}
		}
		
		[Test]
		public void TestUnpackUInt16_ByteArray_PositiveFixNumMaxValueAsInt32_Fail()
		{
			var result = Unpacking.UnpackUInt16( new byte[] { 0xD2, 0x00, 0x00, 0x00, 0x7F } );
			Assert.AreEqual( 5, result.ReadCount );
			Assert.AreEqual( 127L, result.Value );
		}
		
		[Test]
		public void TestUnpackUInt16_Stream_PositiveFixNumMaxValueAsInt32_Fail()
		{
			using ( var buffer = new MemoryStream( new byte[] { 0xD2, 0x00, 0x00, 0x00, 0x7F } ) )
			{
				var result = Unpacking.UnpackUInt16( buffer );
				Assert.AreEqual( 5, buffer.Position );
				Assert.AreEqual( 127L, result );
			}
		}
		
		[Test]
		public void TestUnpackUInt16_ByteArray_PositiveFixNumMaxValueAsUInt32_Fail()
		{
			var result = Unpacking.UnpackUInt16( new byte[] { 0xCE, 0x00, 0x00, 0x00, 0x7F } );
			Assert.AreEqual( 5, result.ReadCount );
			Assert.AreEqual( 127L, result.Value );
		}
		
		[Test]
		public void TestUnpackUInt16_Stream_PositiveFixNumMaxValueAsUInt32_Fail()
		{
			using ( var buffer = new MemoryStream( new byte[] { 0xCE, 0x00, 0x00, 0x00, 0x7F } ) )
			{
				var result = Unpacking.UnpackUInt16( buffer );
				Assert.AreEqual( 5, buffer.Position );
				Assert.AreEqual( 127L, result );
			}
		}
		
		[Test]
		public void TestUnpackUInt16_ByteArray_PositiveFixNumMaxValueAsInt16_Fail()
		{
			var result = Unpacking.UnpackUInt16( new byte[] { 0xD1, 0x00, 0x7F } );
			Assert.AreEqual( 3, result.ReadCount );
			Assert.AreEqual( 127L, result.Value );
		}
		
		[Test]
		public void TestUnpackUInt16_Stream_PositiveFixNumMaxValueAsInt16_Fail()
		{
			using ( var buffer = new MemoryStream( new byte[] { 0xD1, 0x00, 0x7F } ) )
			{
				var result = Unpacking.UnpackUInt16( buffer );
				Assert.AreEqual( 3, buffer.Position );
				Assert.AreEqual( 127L, result );
			}
		}
		
		[Test]
		public void TestUnpackUInt16_ByteArray_PositiveFixNumMaxValueAsUInt16_Fail()
		{
			var result = Unpacking.UnpackUInt16( new byte[] { 0xCD, 0x00, 0x7F } );
			Assert.AreEqual( 3, result.ReadCount );
			Assert.AreEqual( 127L, result.Value );
		}
		
		[Test]
		public void TestUnpackUInt16_Stream_PositiveFixNumMaxValueAsUInt16_Fail()
		{
			using ( var buffer = new MemoryStream( new byte[] { 0xCD, 0x00, 0x7F } ) )
			{
				var result = Unpacking.UnpackUInt16( buffer );
				Assert.AreEqual( 3, buffer.Position );
				Assert.AreEqual( 127L, result );
			}
		}
		
		[Test]
		public void TestUnpackUInt16_ByteArray_PositiveFixNumMaxValueAsInt8_Fail()
		{
			var result = Unpacking.UnpackUInt16( new byte[] { 0xD0, 0x7F } );
			Assert.AreEqual( 2, result.ReadCount );
			Assert.AreEqual( 127L, result.Value );
		}
		
		[Test]
		public void TestUnpackUInt16_Stream_PositiveFixNumMaxValueAsInt8_Fail()
		{
			using ( var buffer = new MemoryStream( new byte[] { 0xD0, 0x7F } ) )
			{
				var result = Unpacking.UnpackUInt16( buffer );
				Assert.AreEqual( 2, buffer.Position );
				Assert.AreEqual( 127L, result );
			}
		}
		
		[Test]
		public void TestUnpackUInt16_ByteArray_PositiveFixNumMaxValueAsUInt8_Fail()
		{
			var result = Unpacking.UnpackUInt16( new byte[] { 0xCC, 0x7F } );
			Assert.AreEqual( 2, result.ReadCount );
			Assert.AreEqual( 127L, result.Value );
		}
		
		[Test]
		public void TestUnpackUInt16_Stream_PositiveFixNumMaxValueAsUInt8_Fail()
		{
			using ( var buffer = new MemoryStream( new byte[] { 0xCC, 0x7F } ) )
			{
				var result = Unpacking.UnpackUInt16( buffer );
				Assert.AreEqual( 2, buffer.Position );
				Assert.AreEqual( 127L, result );
			}
		}
		
		[Test]
		public void TestUnpackUInt16_ByteArray_PositiveFixNumMaxValueAsPositiveFixNum127_Fail()
		{
			var result = Unpacking.UnpackUInt16( new byte[] { 0x7F } );
			Assert.AreEqual( 1, result.ReadCount );
			Assert.AreEqual( 127L, result.Value );
		}
		
		[Test]
		public void TestUnpackUInt16_Stream_PositiveFixNumMaxValueAsPositiveFixNum127_Fail()
		{
			using ( var buffer = new MemoryStream( new byte[] { 0x7F } ) )
			{
				var result = Unpacking.UnpackUInt16( buffer );
				Assert.AreEqual( 1, buffer.Position );
				Assert.AreEqual( 127L, result );
			}
		}
		
		[Test]
		public void TestUnpackUInt16_ByteArray_PositiveFixNumMaxValuePlusOneAsInt64_Fail()
		{
			var result = Unpacking.UnpackUInt16( new byte[] { 0xD3, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x80 } );
			Assert.AreEqual( 9, result.ReadCount );
			Assert.AreEqual( 128L, result.Value );
		}
		
		[Test]
		public void TestUnpackUInt16_Stream_PositiveFixNumMaxValuePlusOneAsInt64_Fail()
		{
			using ( var buffer = new MemoryStream( new byte[] { 0xD3, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x80 } ) )
			{
				var result = Unpacking.UnpackUInt16( buffer );
				Assert.AreEqual( 9, buffer.Position );
				Assert.AreEqual( 128L, result );
			}
		}
		
		[Test]
		public void TestUnpackUInt16_ByteArray_PositiveFixNumMaxValuePlusOneAsUInt64_Fail()
		{
			var result = Unpacking.UnpackUInt16( new byte[] { 0xCF, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x80 } );
			Assert.AreEqual( 9, result.ReadCount );
			Assert.AreEqual( 128L, result.Value );
		}
		
		[Test]
		public void TestUnpackUInt16_Stream_PositiveFixNumMaxValuePlusOneAsUInt64_Fail()
		{
			using ( var buffer = new MemoryStream( new byte[] { 0xCF, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x80 } ) )
			{
				var result = Unpacking.UnpackUInt16( buffer );
				Assert.AreEqual( 9, buffer.Position );
				Assert.AreEqual( 128L, result );
			}
		}
		
		[Test]
		public void TestUnpackUInt16_ByteArray_PositiveFixNumMaxValuePlusOneAsInt32_Fail()
		{
			var result = Unpacking.UnpackUInt16( new byte[] { 0xD2, 0x00, 0x00, 0x00, 0x80 } );
			Assert.AreEqual( 5, result.ReadCount );
			Assert.AreEqual( 128L, result.Value );
		}
		
		[Test]
		public void TestUnpackUInt16_Stream_PositiveFixNumMaxValuePlusOneAsInt32_Fail()
		{
			using ( var buffer = new MemoryStream( new byte[] { 0xD2, 0x00, 0x00, 0x00, 0x80 } ) )
			{
				var result = Unpacking.UnpackUInt16( buffer );
				Assert.AreEqual( 5, buffer.Position );
				Assert.AreEqual( 128L, result );
			}
		}
		
		[Test]
		public void TestUnpackUInt16_ByteArray_PositiveFixNumMaxValuePlusOneAsUInt32_Fail()
		{
			var result = Unpacking.UnpackUInt16( new byte[] { 0xCE, 0x00, 0x00, 0x00, 0x80 } );
			Assert.AreEqual( 5, result.ReadCount );
			Assert.AreEqual( 128L, result.Value );
		}
		
		[Test]
		public void TestUnpackUInt16_Stream_PositiveFixNumMaxValuePlusOneAsUInt32_Fail()
		{
			using ( var buffer = new MemoryStream( new byte[] { 0xCE, 0x00, 0x00, 0x00, 0x80 } ) )
			{
				var result = Unpacking.UnpackUInt16( buffer );
				Assert.AreEqual( 5, buffer.Position );
				Assert.AreEqual( 128L, result );
			}
		}
		
		[Test]
		public void TestUnpackUInt16_ByteArray_PositiveFixNumMaxValuePlusOneAsInt16_Fail()
		{
			var result = Unpacking.UnpackUInt16( new byte[] { 0xD1, 0x00, 0x80 } );
			Assert.AreEqual( 3, result.ReadCount );
			Assert.AreEqual( 128L, result.Value );
		}
		
		[Test]
		public void TestUnpackUInt16_Stream_PositiveFixNumMaxValuePlusOneAsInt16_Fail()
		{
			using ( var buffer = new MemoryStream( new byte[] { 0xD1, 0x00, 0x80 } ) )
			{
				var result = Unpacking.UnpackUInt16( buffer );
				Assert.AreEqual( 3, buffer.Position );
				Assert.AreEqual( 128L, result );
			}
		}
		
		[Test]
		public void TestUnpackUInt16_ByteArray_PositiveFixNumMaxValuePlusOneAsUInt16_Fail()
		{
			var result = Unpacking.UnpackUInt16( new byte[] { 0xCD, 0x00, 0x80 } );
			Assert.AreEqual( 3, result.ReadCount );
			Assert.AreEqual( 128L, result.Value );
		}
		
		[Test]
		public void TestUnpackUInt16_Stream_PositiveFixNumMaxValuePlusOneAsUInt16_Fail()
		{
			using ( var buffer = new MemoryStream( new byte[] { 0xCD, 0x00, 0x80 } ) )
			{
				var result = Unpacking.UnpackUInt16( buffer );
				Assert.AreEqual( 3, buffer.Position );
				Assert.AreEqual( 128L, result );
			}
		}
		
		[Test]
		public void TestUnpackUInt16_ByteArray_PositiveFixNumMaxValuePlusOneAsUInt8_Fail()
		{
			var result = Unpacking.UnpackUInt16( new byte[] { 0xCC, 0x80 } );
			Assert.AreEqual( 2, result.ReadCount );
			Assert.AreEqual( 128L, result.Value );
		}
		
		[Test]
		public void TestUnpackUInt16_Stream_PositiveFixNumMaxValuePlusOneAsUInt8_Fail()
		{
			using ( var buffer = new MemoryStream( new byte[] { 0xCC, 0x80 } ) )
			{
				var result = Unpacking.UnpackUInt16( buffer );
				Assert.AreEqual( 2, buffer.Position );
				Assert.AreEqual( 128L, result );
			}
		}
		
		[Test]
		public void TestUnpackUInt16_ByteArray_ByteMaxValueAsInt64_Fail()
		{
			var result = Unpacking.UnpackUInt16( new byte[] { 0xD3, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0xFF } );
			Assert.AreEqual( 9, result.ReadCount );
			Assert.AreEqual( 255L, result.Value );
		}
		
		[Test]
		public void TestUnpackUInt16_Stream_ByteMaxValueAsInt64_Fail()
		{
			using ( var buffer = new MemoryStream( new byte[] { 0xD3, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0xFF } ) )
			{
				var result = Unpacking.UnpackUInt16( buffer );
				Assert.AreEqual( 9, buffer.Position );
				Assert.AreEqual( 255L, result );
			}
		}
		
		[Test]
		public void TestUnpackUInt16_ByteArray_ByteMaxValueAsUInt64_Fail()
		{
			var result = Unpacking.UnpackUInt16( new byte[] { 0xCF, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0xFF } );
			Assert.AreEqual( 9, result.ReadCount );
			Assert.AreEqual( 255L, result.Value );
		}
		
		[Test]
		public void TestUnpackUInt16_Stream_ByteMaxValueAsUInt64_Fail()
		{
			using ( var buffer = new MemoryStream( new byte[] { 0xCF, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0xFF } ) )
			{
				var result = Unpacking.UnpackUInt16( buffer );
				Assert.AreEqual( 9, buffer.Position );
				Assert.AreEqual( 255L, result );
			}
		}
		
		[Test]
		public void TestUnpackUInt16_ByteArray_ByteMaxValueAsInt32_Fail()
		{
			var result = Unpacking.UnpackUInt16( new byte[] { 0xD2, 0x00, 0x00, 0x00, 0xFF } );
			Assert.AreEqual( 5, result.ReadCount );
			Assert.AreEqual( 255L, result.Value );
		}
		
		[Test]
		public void TestUnpackUInt16_Stream_ByteMaxValueAsInt32_Fail()
		{
			using ( var buffer = new MemoryStream( new byte[] { 0xD2, 0x00, 0x00, 0x00, 0xFF } ) )
			{
				var result = Unpacking.UnpackUInt16( buffer );
				Assert.AreEqual( 5, buffer.Position );
				Assert.AreEqual( 255L, result );
			}
		}
		
		[Test]
		public void TestUnpackUInt16_ByteArray_ByteMaxValueAsUInt32_Fail()
		{
			var result = Unpacking.UnpackUInt16( new byte[] { 0xCE, 0x00, 0x00, 0x00, 0xFF } );
			Assert.AreEqual( 5, result.ReadCount );
			Assert.AreEqual( 255L, result.Value );
		}
		
		[Test]
		public void TestUnpackUInt16_Stream_ByteMaxValueAsUInt32_Fail()
		{
			using ( var buffer = new MemoryStream( new byte[] { 0xCE, 0x00, 0x00, 0x00, 0xFF } ) )
			{
				var result = Unpacking.UnpackUInt16( buffer );
				Assert.AreEqual( 5, buffer.Position );
				Assert.AreEqual( 255L, result );
			}
		}
		
		[Test]
		public void TestUnpackUInt16_ByteArray_ByteMaxValueAsInt16_Fail()
		{
			var result = Unpacking.UnpackUInt16( new byte[] { 0xD1, 0x00, 0xFF } );
			Assert.AreEqual( 3, result.ReadCount );
			Assert.AreEqual( 255L, result.Value );
		}
		
		[Test]
		public void TestUnpackUInt16_Stream_ByteMaxValueAsInt16_Fail()
		{
			using ( var buffer = new MemoryStream( new byte[] { 0xD1, 0x00, 0xFF } ) )
			{
				var result = Unpacking.UnpackUInt16( buffer );
				Assert.AreEqual( 3, buffer.Position );
				Assert.AreEqual( 255L, result );
			}
		}
		
		[Test]
		public void TestUnpackUInt16_ByteArray_ByteMaxValueAsUInt16_Fail()
		{
			var result = Unpacking.UnpackUInt16( new byte[] { 0xCD, 0x00, 0xFF } );
			Assert.AreEqual( 3, result.ReadCount );
			Assert.AreEqual( 255L, result.Value );
		}
		
		[Test]
		public void TestUnpackUInt16_Stream_ByteMaxValueAsUInt16_Fail()
		{
			using ( var buffer = new MemoryStream( new byte[] { 0xCD, 0x00, 0xFF } ) )
			{
				var result = Unpacking.UnpackUInt16( buffer );
				Assert.AreEqual( 3, buffer.Position );
				Assert.AreEqual( 255L, result );
			}
		}
		
		[Test]
		public void TestUnpackUInt16_ByteArray_ByteMaxValueAsUInt8_Fail()
		{
			var result = Unpacking.UnpackUInt16( new byte[] { 0xCC, 0xFF } );
			Assert.AreEqual( 2, result.ReadCount );
			Assert.AreEqual( 255L, result.Value );
		}
		
		[Test]
		public void TestUnpackUInt16_Stream_ByteMaxValueAsUInt8_Fail()
		{
			using ( var buffer = new MemoryStream( new byte[] { 0xCC, 0xFF } ) )
			{
				var result = Unpacking.UnpackUInt16( buffer );
				Assert.AreEqual( 2, buffer.Position );
				Assert.AreEqual( 255L, result );
			}
		}
		
		[Test]
		public void TestUnpackUInt16_ByteArray_ByteMaxValuePlusOneAsInt64_Fail()
		{
			var result = Unpacking.UnpackUInt16( new byte[] { 0xD3, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x01, 0x00 } );
			Assert.AreEqual( 9, result.ReadCount );
			Assert.AreEqual( 256L, result.Value );
		}
		
		[Test]
		public void TestUnpackUInt16_Stream_ByteMaxValuePlusOneAsInt64_Fail()
		{
			using ( var buffer = new MemoryStream( new byte[] { 0xD3, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x01, 0x00 } ) )
			{
				var result = Unpacking.UnpackUInt16( buffer );
				Assert.AreEqual( 9, buffer.Position );
				Assert.AreEqual( 256L, result );
			}
		}
		
		[Test]
		public void TestUnpackUInt16_ByteArray_ByteMaxValuePlusOneAsUInt64_Fail()
		{
			var result = Unpacking.UnpackUInt16( new byte[] { 0xCF, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x01, 0x00 } );
			Assert.AreEqual( 9, result.ReadCount );
			Assert.AreEqual( 256L, result.Value );
		}
		
		[Test]
		public void TestUnpackUInt16_Stream_ByteMaxValuePlusOneAsUInt64_Fail()
		{
			using ( var buffer = new MemoryStream( new byte[] { 0xCF, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x01, 0x00 } ) )
			{
				var result = Unpacking.UnpackUInt16( buffer );
				Assert.AreEqual( 9, buffer.Position );
				Assert.AreEqual( 256L, result );
			}
		}
		
		[Test]
		public void TestUnpackUInt16_ByteArray_ByteMaxValuePlusOneAsInt32_Fail()
		{
			var result = Unpacking.UnpackUInt16( new byte[] { 0xD2, 0x00, 0x00, 0x01, 0x00 } );
			Assert.AreEqual( 5, result.ReadCount );
			Assert.AreEqual( 256L, result.Value );
		}
		
		[Test]
		public void TestUnpackUInt16_Stream_ByteMaxValuePlusOneAsInt32_Fail()
		{
			using ( var buffer = new MemoryStream( new byte[] { 0xD2, 0x00, 0x00, 0x01, 0x00 } ) )
			{
				var result = Unpacking.UnpackUInt16( buffer );
				Assert.AreEqual( 5, buffer.Position );
				Assert.AreEqual( 256L, result );
			}
		}
		
		[Test]
		public void TestUnpackUInt16_ByteArray_ByteMaxValuePlusOneAsUInt32_Fail()
		{
			var result = Unpacking.UnpackUInt16( new byte[] { 0xCE, 0x00, 0x00, 0x01, 0x00 } );
			Assert.AreEqual( 5, result.ReadCount );
			Assert.AreEqual( 256L, result.Value );
		}
		
		[Test]
		public void TestUnpackUInt16_Stream_ByteMaxValuePlusOneAsUInt32_Fail()
		{
			using ( var buffer = new MemoryStream( new byte[] { 0xCE, 0x00, 0x00, 0x01, 0x00 } ) )
			{
				var result = Unpacking.UnpackUInt16( buffer );
				Assert.AreEqual( 5, buffer.Position );
				Assert.AreEqual( 256L, result );
			}
		}
		
		[Test]
		public void TestUnpackUInt16_ByteArray_ByteMaxValuePlusOneAsInt16_Fail()
		{
			var result = Unpacking.UnpackUInt16( new byte[] { 0xD1, 0x01, 0x00 } );
			Assert.AreEqual( 3, result.ReadCount );
			Assert.AreEqual( 256L, result.Value );
		}
		
		[Test]
		public void TestUnpackUInt16_Stream_ByteMaxValuePlusOneAsInt16_Fail()
		{
			using ( var buffer = new MemoryStream( new byte[] { 0xD1, 0x01, 0x00 } ) )
			{
				var result = Unpacking.UnpackUInt16( buffer );
				Assert.AreEqual( 3, buffer.Position );
				Assert.AreEqual( 256L, result );
			}
		}
		
		[Test]
		public void TestUnpackUInt16_ByteArray_ByteMaxValuePlusOneAsUInt16_Fail()
		{
			var result = Unpacking.UnpackUInt16( new byte[] { 0xCD, 0x01, 0x00 } );
			Assert.AreEqual( 3, result.ReadCount );
			Assert.AreEqual( 256L, result.Value );
		}
		
		[Test]
		public void TestUnpackUInt16_Stream_ByteMaxValuePlusOneAsUInt16_Fail()
		{
			using ( var buffer = new MemoryStream( new byte[] { 0xCD, 0x01, 0x00 } ) )
			{
				var result = Unpacking.UnpackUInt16( buffer );
				Assert.AreEqual( 3, buffer.Position );
				Assert.AreEqual( 256L, result );
			}
		}
		
		[Test]
		public void TestUnpackUInt16_ByteArray_UInt16MaxValueAsInt64_Fail()
		{
			var result = Unpacking.UnpackUInt16( new byte[] { 0xD3, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0xFF, 0xFF } );
			Assert.AreEqual( 9, result.ReadCount );
			Assert.AreEqual( 65535L, result.Value );
		}
		
		[Test]
		public void TestUnpackUInt16_Stream_UInt16MaxValueAsInt64_Fail()
		{
			using ( var buffer = new MemoryStream( new byte[] { 0xD3, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0xFF, 0xFF } ) )
			{
				var result = Unpacking.UnpackUInt16( buffer );
				Assert.AreEqual( 9, buffer.Position );
				Assert.AreEqual( 65535L, result );
			}
		}
		
		[Test]
		public void TestUnpackUInt16_ByteArray_UInt16MaxValueAsUInt64_Fail()
		{
			var result = Unpacking.UnpackUInt16( new byte[] { 0xCF, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0xFF, 0xFF } );
			Assert.AreEqual( 9, result.ReadCount );
			Assert.AreEqual( 65535L, result.Value );
		}
		
		[Test]
		public void TestUnpackUInt16_Stream_UInt16MaxValueAsUInt64_Fail()
		{
			using ( var buffer = new MemoryStream( new byte[] { 0xCF, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0xFF, 0xFF } ) )
			{
				var result = Unpacking.UnpackUInt16( buffer );
				Assert.AreEqual( 9, buffer.Position );
				Assert.AreEqual( 65535L, result );
			}
		}
		
		[Test]
		public void TestUnpackUInt16_ByteArray_UInt16MaxValueAsInt32_Fail()
		{
			var result = Unpacking.UnpackUInt16( new byte[] { 0xD2, 0x00, 0x00, 0xFF, 0xFF } );
			Assert.AreEqual( 5, result.ReadCount );
			Assert.AreEqual( 65535L, result.Value );
		}
		
		[Test]
		public void TestUnpackUInt16_Stream_UInt16MaxValueAsInt32_Fail()
		{
			using ( var buffer = new MemoryStream( new byte[] { 0xD2, 0x00, 0x00, 0xFF, 0xFF } ) )
			{
				var result = Unpacking.UnpackUInt16( buffer );
				Assert.AreEqual( 5, buffer.Position );
				Assert.AreEqual( 65535L, result );
			}
		}
		
		[Test]
		public void TestUnpackUInt16_ByteArray_UInt16MaxValueAsUInt32_Fail()
		{
			var result = Unpacking.UnpackUInt16( new byte[] { 0xCE, 0x00, 0x00, 0xFF, 0xFF } );
			Assert.AreEqual( 5, result.ReadCount );
			Assert.AreEqual( 65535L, result.Value );
		}
		
		[Test]
		public void TestUnpackUInt16_Stream_UInt16MaxValueAsUInt32_Fail()
		{
			using ( var buffer = new MemoryStream( new byte[] { 0xCE, 0x00, 0x00, 0xFF, 0xFF } ) )
			{
				var result = Unpacking.UnpackUInt16( buffer );
				Assert.AreEqual( 5, buffer.Position );
				Assert.AreEqual( 65535L, result );
			}
		}
		
		[Test]
		public void TestUnpackUInt16_ByteArray_UInt16MaxValueAsUInt16_Fail()
		{
			var result = Unpacking.UnpackUInt16( new byte[] { 0xCD, 0xFF, 0xFF } );
			Assert.AreEqual( 3, result.ReadCount );
			Assert.AreEqual( 65535L, result.Value );
		}
		
		[Test]
		public void TestUnpackUInt16_Stream_UInt16MaxValueAsUInt16_Fail()
		{
			using ( var buffer = new MemoryStream( new byte[] { 0xCD, 0xFF, 0xFF } ) )
			{
				var result = Unpacking.UnpackUInt16( buffer );
				Assert.AreEqual( 3, buffer.Position );
				Assert.AreEqual( 65535L, result );
			}
		}
		
		[Test]
		[ExpectedException( typeof( MessageTypeException ) )]
		public void TestUnpackUInt16_ByteArray_UInt16MaxValuePlusOneAsInt64_AsIs()
		{
			var result = Unpacking.UnpackUInt16( new byte[] { 0xD3, 0x00, 0x00, 0x00, 0x00, 0x00, 0x01, 0x00, 0x00 } );
		}
		
		[Test]
		[ExpectedException( typeof( MessageTypeException ) )]
		public void TestUnpackUInt16_Stream_UInt16MaxValuePlusOneAsInt64_AsIs()
		{
			using ( var buffer = new MemoryStream( new byte[] { 0xD3, 0x00, 0x00, 0x00, 0x00, 0x00, 0x01, 0x00, 0x00 } ) )
			{
				var result = Unpacking.UnpackUInt16( buffer );
			}
		}
		
		[Test]
		[ExpectedException( typeof( MessageTypeException ) )]
		public void TestUnpackUInt16_ByteArray_UInt16MaxValuePlusOneAsUInt64_AsIs()
		{
			var result = Unpacking.UnpackUInt16( new byte[] { 0xCF, 0x00, 0x00, 0x00, 0x00, 0x00, 0x01, 0x00, 0x00 } );
		}
		
		[Test]
		[ExpectedException( typeof( MessageTypeException ) )]
		public void TestUnpackUInt16_Stream_UInt16MaxValuePlusOneAsUInt64_AsIs()
		{
			using ( var buffer = new MemoryStream( new byte[] { 0xCF, 0x00, 0x00, 0x00, 0x00, 0x00, 0x01, 0x00, 0x00 } ) )
			{
				var result = Unpacking.UnpackUInt16( buffer );
			}
		}
		
		[Test]
		[ExpectedException( typeof( MessageTypeException ) )]
		public void TestUnpackUInt16_ByteArray_UInt16MaxValuePlusOneAsInt32_AsIs()
		{
			var result = Unpacking.UnpackUInt16( new byte[] { 0xD2, 0x00, 0x01, 0x00, 0x00 } );
		}
		
		[Test]
		[ExpectedException( typeof( MessageTypeException ) )]
		public void TestUnpackUInt16_Stream_UInt16MaxValuePlusOneAsInt32_AsIs()
		{
			using ( var buffer = new MemoryStream( new byte[] { 0xD2, 0x00, 0x01, 0x00, 0x00 } ) )
			{
				var result = Unpacking.UnpackUInt16( buffer );
			}
		}
		
		[Test]
		[ExpectedException( typeof( MessageTypeException ) )]
		public void TestUnpackUInt16_ByteArray_UInt16MaxValuePlusOneAsUInt32_AsIs()
		{
			var result = Unpacking.UnpackUInt16( new byte[] { 0xCE, 0x00, 0x01, 0x00, 0x00 } );
		}
		
		[Test]
		[ExpectedException( typeof( MessageTypeException ) )]
		public void TestUnpackUInt16_Stream_UInt16MaxValuePlusOneAsUInt32_AsIs()
		{
			using ( var buffer = new MemoryStream( new byte[] { 0xCE, 0x00, 0x01, 0x00, 0x00 } ) )
			{
				var result = Unpacking.UnpackUInt16( buffer );
			}
		}
		
		[Test]
		[ExpectedException( typeof( MessageTypeException ) )]
		public void TestUnpackUInt16_ByteArray_UInt32MaxValueAsInt64_AsIs()
		{
			var result = Unpacking.UnpackUInt16( new byte[] { 0xD3, 0x00, 0x00, 0x00, 0x00, 0xFF, 0xFF, 0xFF, 0xFF } );
		}
		
		[Test]
		[ExpectedException( typeof( MessageTypeException ) )]
		public void TestUnpackUInt16_Stream_UInt32MaxValueAsInt64_AsIs()
		{
			using ( var buffer = new MemoryStream( new byte[] { 0xD3, 0x00, 0x00, 0x00, 0x00, 0xFF, 0xFF, 0xFF, 0xFF } ) )
			{
				var result = Unpacking.UnpackUInt16( buffer );
			}
		}
		
		[Test]
		[ExpectedException( typeof( MessageTypeException ) )]
		public void TestUnpackUInt16_ByteArray_UInt32MaxValueAsUInt64_AsIs()
		{
			var result = Unpacking.UnpackUInt16( new byte[] { 0xCF, 0x00, 0x00, 0x00, 0x00, 0xFF, 0xFF, 0xFF, 0xFF } );
		}
		
		[Test]
		[ExpectedException( typeof( MessageTypeException ) )]
		public void TestUnpackUInt16_Stream_UInt32MaxValueAsUInt64_AsIs()
		{
			using ( var buffer = new MemoryStream( new byte[] { 0xCF, 0x00, 0x00, 0x00, 0x00, 0xFF, 0xFF, 0xFF, 0xFF } ) )
			{
				var result = Unpacking.UnpackUInt16( buffer );
			}
		}
		
		[Test]
		[ExpectedException( typeof( MessageTypeException ) )]
		public void TestUnpackUInt16_ByteArray_UInt32MaxValueAsUInt32_AsIs()
		{
			var result = Unpacking.UnpackUInt16( new byte[] { 0xCE, 0xFF, 0xFF, 0xFF, 0xFF } );
		}
		
		[Test]
		[ExpectedException( typeof( MessageTypeException ) )]
		public void TestUnpackUInt16_Stream_UInt32MaxValueAsUInt32_AsIs()
		{
			using ( var buffer = new MemoryStream( new byte[] { 0xCE, 0xFF, 0xFF, 0xFF, 0xFF } ) )
			{
				var result = Unpacking.UnpackUInt16( buffer );
			}
		}
		
		[Test]
		[ExpectedException( typeof( MessageTypeException ) )]
		public void TestUnpackUInt16_ByteArray_UInt32MaxValuePlusOneAsInt64_AsIs()
		{
			var result = Unpacking.UnpackUInt16( new byte[] { 0xD3, 0x00, 0x00, 0x00, 0x01, 0x00, 0x00, 0x00, 0x00 } );
		}
		
		[Test]
		[ExpectedException( typeof( MessageTypeException ) )]
		public void TestUnpackUInt16_Stream_UInt32MaxValuePlusOneAsInt64_AsIs()
		{
			using ( var buffer = new MemoryStream( new byte[] { 0xD3, 0x00, 0x00, 0x00, 0x01, 0x00, 0x00, 0x00, 0x00 } ) )
			{
				var result = Unpacking.UnpackUInt16( buffer );
			}
		}
		
		[Test]
		[ExpectedException( typeof( MessageTypeException ) )]
		public void TestUnpackUInt16_ByteArray_UInt32MaxValuePlusOneAsUInt64_AsIs()
		{
			var result = Unpacking.UnpackUInt16( new byte[] { 0xCF, 0x00, 0x00, 0x00, 0x01, 0x00, 0x00, 0x00, 0x00 } );
		}
		
		[Test]
		[ExpectedException( typeof( MessageTypeException ) )]
		public void TestUnpackUInt16_Stream_UInt32MaxValuePlusOneAsUInt64_AsIs()
		{
			using ( var buffer = new MemoryStream( new byte[] { 0xCF, 0x00, 0x00, 0x00, 0x01, 0x00, 0x00, 0x00, 0x00 } ) )
			{
				var result = Unpacking.UnpackUInt16( buffer );
			}
		}
		
		[Test]
		[ExpectedException( typeof( MessageTypeException ) )]
		public void TestUnpackUInt16_ByteArray_UInt64MaxValueAsUInt64_AsIs()
		{
			var result = Unpacking.UnpackUInt16( new byte[] { 0xCF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF } );
		}
		
		[Test]
		[ExpectedException( typeof( MessageTypeException ) )]
		public void TestUnpackUInt16_Stream_UInt64MaxValueAsUInt64_AsIs()
		{
			using ( var buffer = new MemoryStream( new byte[] { 0xCF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF } ) )
			{
				var result = Unpacking.UnpackUInt16( buffer );
			}
		}
		
		[Test]
		[ExpectedException( typeof( ArgumentException ) )]
		public void TestUnpackUInt16_ByteArray_Empty()
		{
			Unpacking.UnpackUInt16( new byte[ 0 ] );
		}

		[Test]
		[ExpectedException( typeof( ArgumentNullException ) )]
		public void TestUnpackUInt16_ByteArray_Null()
		{
			Unpacking.UnpackUInt16( default( byte[] ) );
		}

		[Test]
		[ExpectedException( typeof( ArgumentNullException ) )]
		public void TestUnpackUInt16_ByteArray_Offset_Null()
		{
			Unpacking.UnpackUInt16( default( byte[] ), 0 );
		}

		[Test]
		[ExpectedException( typeof( ArgumentOutOfRangeException ) )]
		public void TestUnpackUInt16_ByteArray_Offset_OffsetIsNegative()
		{
			Unpacking.UnpackUInt16( new byte[]{ 0x1 }, -1 );
		}

		[Test]
		[ExpectedException( typeof( ArgumentException ) )]
		public void TestUnpackUInt16_ByteArray_Offset_OffsetIsTooBig()
		{
			Unpacking.UnpackUInt16( new byte[]{ 0x1 }, 1 );
		}

		[Test]
		[ExpectedException( typeof( ArgumentException ) )]
		public void TestUnpackUInt16_ByteArray_Offset_Empty()
		{
			Unpacking.UnpackUInt16( new byte[ 0 ], 0 );
		}

		[Test]
		[ExpectedException( typeof( ArgumentNullException ) )]
		public void TestUnpackUInt16_Stream_Null()
		{
			Unpacking.UnpackUInt16( default( Stream ) );
		}

		[Test]
		public void TestUnpackUInt16_ByteArray_Offset_OffsetIsValid_OffsetIsRespected()
		{
			// Offset 1 is positive fix num 1.
			var result = Unpacking.UnpackUInt16( new byte[] { 0xFF, 0x57, 0xFF }, 1 );
			Assert.AreEqual( 1, result.ReadCount );
			Assert.AreEqual( 0x57, result.Value );
		}

		[Test]
		[ExpectedException( typeof( MessageTypeException ) )]
		public void TestUnpackUInt16_ByteArray_Null_Nil()
		{
			Unpacking.UnpackUInt16( new byte[] { 0xC0 } );
		}
	
		[Test]
		[ExpectedException( typeof( MessageTypeException ) )]
		public void TestUnpackUInt16_ByteArray_NotUInt16()
		{
			Unpacking.UnpackUInt16( new byte[] { 0xA0 } );
		}
	}

	partial class UnpackingTest_Combinations_Int32
	{
		[Test]
		[ExpectedException( typeof( MessageTypeException ) )]
		public void TestUnpackInt32_ByteArray_Int64MinValueAsInt64_AsIs()
		{
			var result = Unpacking.UnpackInt32( new byte[] { 0xD3, 0x80, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 } );
		}
		
		[Test]
		[ExpectedException( typeof( MessageTypeException ) )]
		public void TestUnpackInt32_Stream_Int64MinValueAsInt64_AsIs()
		{
			using ( var buffer = new MemoryStream( new byte[] { 0xD3, 0x80, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 } ) )
			{
				var result = Unpacking.UnpackInt32( buffer );
			}
		}
		
		[Test]
		[ExpectedException( typeof( MessageTypeException ) )]
		public void TestUnpackInt32_ByteArray_Int32MinValueMinusOneAsInt64_AsIs()
		{
			var result = Unpacking.UnpackInt32( new byte[] { 0xD3, 0xFF, 0xFF, 0xFF, 0xFF, 0x7F, 0xFF, 0xFF, 0xFF } );
		}
		
		[Test]
		[ExpectedException( typeof( MessageTypeException ) )]
		public void TestUnpackInt32_Stream_Int32MinValueMinusOneAsInt64_AsIs()
		{
			using ( var buffer = new MemoryStream( new byte[] { 0xD3, 0xFF, 0xFF, 0xFF, 0xFF, 0x7F, 0xFF, 0xFF, 0xFF } ) )
			{
				var result = Unpacking.UnpackInt32( buffer );
			}
		}
		
		[Test]
		public void TestUnpackInt32_ByteArray_Int32MinValueAsInt64_Fail()
		{
			var result = Unpacking.UnpackInt32( new byte[] { 0xD3, 0xFF, 0xFF, 0xFF, 0xFF, 0x80, 0x00, 0x00, 0x00 } );
			Assert.AreEqual( 9, result.ReadCount );
			Assert.AreEqual( -2147483648L, result.Value );
		}
		
		[Test]
		public void TestUnpackInt32_Stream_Int32MinValueAsInt64_Fail()
		{
			using ( var buffer = new MemoryStream( new byte[] { 0xD3, 0xFF, 0xFF, 0xFF, 0xFF, 0x80, 0x00, 0x00, 0x00 } ) )
			{
				var result = Unpacking.UnpackInt32( buffer );
				Assert.AreEqual( 9, buffer.Position );
				Assert.AreEqual( -2147483648L, result );
			}
		}
		
		[Test]
		public void TestUnpackInt32_ByteArray_Int32MinValueAsInt32_Fail()
		{
			var result = Unpacking.UnpackInt32( new byte[] { 0xD2, 0x80, 0x00, 0x00, 0x00 } );
			Assert.AreEqual( 5, result.ReadCount );
			Assert.AreEqual( -2147483648L, result.Value );
		}
		
		[Test]
		public void TestUnpackInt32_Stream_Int32MinValueAsInt32_Fail()
		{
			using ( var buffer = new MemoryStream( new byte[] { 0xD2, 0x80, 0x00, 0x00, 0x00 } ) )
			{
				var result = Unpacking.UnpackInt32( buffer );
				Assert.AreEqual( 5, buffer.Position );
				Assert.AreEqual( -2147483648L, result );
			}
		}
		
		[Test]
		public void TestUnpackInt32_ByteArray_Int16MinValueMinusOneAsInt64_Fail()
		{
			var result = Unpacking.UnpackInt32( new byte[] { 0xD3, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0x7F, 0xFF } );
			Assert.AreEqual( 9, result.ReadCount );
			Assert.AreEqual( -32769L, result.Value );
		}
		
		[Test]
		public void TestUnpackInt32_Stream_Int16MinValueMinusOneAsInt64_Fail()
		{
			using ( var buffer = new MemoryStream( new byte[] { 0xD3, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0x7F, 0xFF } ) )
			{
				var result = Unpacking.UnpackInt32( buffer );
				Assert.AreEqual( 9, buffer.Position );
				Assert.AreEqual( -32769L, result );
			}
		}
		
		[Test]
		public void TestUnpackInt32_ByteArray_Int16MinValueMinusOneAsInt32_Fail()
		{
			var result = Unpacking.UnpackInt32( new byte[] { 0xD2, 0xFF, 0xFF, 0x7F, 0xFF } );
			Assert.AreEqual( 5, result.ReadCount );
			Assert.AreEqual( -32769L, result.Value );
		}
		
		[Test]
		public void TestUnpackInt32_Stream_Int16MinValueMinusOneAsInt32_Fail()
		{
			using ( var buffer = new MemoryStream( new byte[] { 0xD2, 0xFF, 0xFF, 0x7F, 0xFF } ) )
			{
				var result = Unpacking.UnpackInt32( buffer );
				Assert.AreEqual( 5, buffer.Position );
				Assert.AreEqual( -32769L, result );
			}
		}
		
		[Test]
		public void TestUnpackInt32_ByteArray_Int16MinValueAsInt64_Fail()
		{
			var result = Unpacking.UnpackInt32( new byte[] { 0xD3, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0x80, 0x00 } );
			Assert.AreEqual( 9, result.ReadCount );
			Assert.AreEqual( -32768L, result.Value );
		}
		
		[Test]
		public void TestUnpackInt32_Stream_Int16MinValueAsInt64_Fail()
		{
			using ( var buffer = new MemoryStream( new byte[] { 0xD3, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0x80, 0x00 } ) )
			{
				var result = Unpacking.UnpackInt32( buffer );
				Assert.AreEqual( 9, buffer.Position );
				Assert.AreEqual( -32768L, result );
			}
		}
		
		[Test]
		public void TestUnpackInt32_ByteArray_Int16MinValueAsInt32_Fail()
		{
			var result = Unpacking.UnpackInt32( new byte[] { 0xD2, 0xFF, 0xFF, 0x80, 0x00 } );
			Assert.AreEqual( 5, result.ReadCount );
			Assert.AreEqual( -32768L, result.Value );
		}
		
		[Test]
		public void TestUnpackInt32_Stream_Int16MinValueAsInt32_Fail()
		{
			using ( var buffer = new MemoryStream( new byte[] { 0xD2, 0xFF, 0xFF, 0x80, 0x00 } ) )
			{
				var result = Unpacking.UnpackInt32( buffer );
				Assert.AreEqual( 5, buffer.Position );
				Assert.AreEqual( -32768L, result );
			}
		}
		
		[Test]
		public void TestUnpackInt32_ByteArray_Int16MinValueAsInt16_Fail()
		{
			var result = Unpacking.UnpackInt32( new byte[] { 0xD1, 0x80, 0x00 } );
			Assert.AreEqual( 3, result.ReadCount );
			Assert.AreEqual( -32768L, result.Value );
		}
		
		[Test]
		public void TestUnpackInt32_Stream_Int16MinValueAsInt16_Fail()
		{
			using ( var buffer = new MemoryStream( new byte[] { 0xD1, 0x80, 0x00 } ) )
			{
				var result = Unpacking.UnpackInt32( buffer );
				Assert.AreEqual( 3, buffer.Position );
				Assert.AreEqual( -32768L, result );
			}
		}
		
		[Test]
		public void TestUnpackInt32_ByteArray_SByteMinValueMinusOneAsInt64_Fail()
		{
			var result = Unpacking.UnpackInt32( new byte[] { 0xD3, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0x7F } );
			Assert.AreEqual( 9, result.ReadCount );
			Assert.AreEqual( -129L, result.Value );
		}
		
		[Test]
		public void TestUnpackInt32_Stream_SByteMinValueMinusOneAsInt64_Fail()
		{
			using ( var buffer = new MemoryStream( new byte[] { 0xD3, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0x7F } ) )
			{
				var result = Unpacking.UnpackInt32( buffer );
				Assert.AreEqual( 9, buffer.Position );
				Assert.AreEqual( -129L, result );
			}
		}
		
		[Test]
		public void TestUnpackInt32_ByteArray_SByteMinValueMinusOneAsInt32_Fail()
		{
			var result = Unpacking.UnpackInt32( new byte[] { 0xD2, 0xFF, 0xFF, 0xFF, 0x7F } );
			Assert.AreEqual( 5, result.ReadCount );
			Assert.AreEqual( -129L, result.Value );
		}
		
		[Test]
		public void TestUnpackInt32_Stream_SByteMinValueMinusOneAsInt32_Fail()
		{
			using ( var buffer = new MemoryStream( new byte[] { 0xD2, 0xFF, 0xFF, 0xFF, 0x7F } ) )
			{
				var result = Unpacking.UnpackInt32( buffer );
				Assert.AreEqual( 5, buffer.Position );
				Assert.AreEqual( -129L, result );
			}
		}
		
		[Test]
		public void TestUnpackInt32_ByteArray_SByteMinValueMinusOneAsInt16_Fail()
		{
			var result = Unpacking.UnpackInt32( new byte[] { 0xD1, 0xFF, 0x7F } );
			Assert.AreEqual( 3, result.ReadCount );
			Assert.AreEqual( -129L, result.Value );
		}
		
		[Test]
		public void TestUnpackInt32_Stream_SByteMinValueMinusOneAsInt16_Fail()
		{
			using ( var buffer = new MemoryStream( new byte[] { 0xD1, 0xFF, 0x7F } ) )
			{
				var result = Unpacking.UnpackInt32( buffer );
				Assert.AreEqual( 3, buffer.Position );
				Assert.AreEqual( -129L, result );
			}
		}
		
		[Test]
		public void TestUnpackInt32_ByteArray_SByteMinValueAsInt64_Fail()
		{
			var result = Unpacking.UnpackInt32( new byte[] { 0xD3, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0x80 } );
			Assert.AreEqual( 9, result.ReadCount );
			Assert.AreEqual( -128L, result.Value );
		}
		
		[Test]
		public void TestUnpackInt32_Stream_SByteMinValueAsInt64_Fail()
		{
			using ( var buffer = new MemoryStream( new byte[] { 0xD3, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0x80 } ) )
			{
				var result = Unpacking.UnpackInt32( buffer );
				Assert.AreEqual( 9, buffer.Position );
				Assert.AreEqual( -128L, result );
			}
		}
		
		[Test]
		public void TestUnpackInt32_ByteArray_SByteMinValueAsInt32_Fail()
		{
			var result = Unpacking.UnpackInt32( new byte[] { 0xD2, 0xFF, 0xFF, 0xFF, 0x80 } );
			Assert.AreEqual( 5, result.ReadCount );
			Assert.AreEqual( -128L, result.Value );
		}
		
		[Test]
		public void TestUnpackInt32_Stream_SByteMinValueAsInt32_Fail()
		{
			using ( var buffer = new MemoryStream( new byte[] { 0xD2, 0xFF, 0xFF, 0xFF, 0x80 } ) )
			{
				var result = Unpacking.UnpackInt32( buffer );
				Assert.AreEqual( 5, buffer.Position );
				Assert.AreEqual( -128L, result );
			}
		}
		
		[Test]
		public void TestUnpackInt32_ByteArray_SByteMinValueAsInt16_Fail()
		{
			var result = Unpacking.UnpackInt32( new byte[] { 0xD1, 0xFF, 0x80 } );
			Assert.AreEqual( 3, result.ReadCount );
			Assert.AreEqual( -128L, result.Value );
		}
		
		[Test]
		public void TestUnpackInt32_Stream_SByteMinValueAsInt16_Fail()
		{
			using ( var buffer = new MemoryStream( new byte[] { 0xD1, 0xFF, 0x80 } ) )
			{
				var result = Unpacking.UnpackInt32( buffer );
				Assert.AreEqual( 3, buffer.Position );
				Assert.AreEqual( -128L, result );
			}
		}
		
		[Test]
		public void TestUnpackInt32_ByteArray_SByteMinValueAsInt8_Fail()
		{
			var result = Unpacking.UnpackInt32( new byte[] { 0xD0, 0x80 } );
			Assert.AreEqual( 2, result.ReadCount );
			Assert.AreEqual( -128L, result.Value );
		}
		
		[Test]
		public void TestUnpackInt32_Stream_SByteMinValueAsInt8_Fail()
		{
			using ( var buffer = new MemoryStream( new byte[] { 0xD0, 0x80 } ) )
			{
				var result = Unpacking.UnpackInt32( buffer );
				Assert.AreEqual( 2, buffer.Position );
				Assert.AreEqual( -128L, result );
			}
		}
		
		[Test]
		public void TestUnpackInt32_ByteArray_NegativeFixNumMinValueMinusOneAsInt64_Fail()
		{
			var result = Unpacking.UnpackInt32( new byte[] { 0xD3, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xDF } );
			Assert.AreEqual( 9, result.ReadCount );
			Assert.AreEqual( -33L, result.Value );
		}
		
		[Test]
		public void TestUnpackInt32_Stream_NegativeFixNumMinValueMinusOneAsInt64_Fail()
		{
			using ( var buffer = new MemoryStream( new byte[] { 0xD3, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xDF } ) )
			{
				var result = Unpacking.UnpackInt32( buffer );
				Assert.AreEqual( 9, buffer.Position );
				Assert.AreEqual( -33L, result );
			}
		}
		
		[Test]
		public void TestUnpackInt32_ByteArray_NegativeFixNumMinValueMinusOneAsInt32_Fail()
		{
			var result = Unpacking.UnpackInt32( new byte[] { 0xD2, 0xFF, 0xFF, 0xFF, 0xDF } );
			Assert.AreEqual( 5, result.ReadCount );
			Assert.AreEqual( -33L, result.Value );
		}
		
		[Test]
		public void TestUnpackInt32_Stream_NegativeFixNumMinValueMinusOneAsInt32_Fail()
		{
			using ( var buffer = new MemoryStream( new byte[] { 0xD2, 0xFF, 0xFF, 0xFF, 0xDF } ) )
			{
				var result = Unpacking.UnpackInt32( buffer );
				Assert.AreEqual( 5, buffer.Position );
				Assert.AreEqual( -33L, result );
			}
		}
		
		[Test]
		public void TestUnpackInt32_ByteArray_NegativeFixNumMinValueMinusOneAsInt16_Fail()
		{
			var result = Unpacking.UnpackInt32( new byte[] { 0xD1, 0xFF, 0xDF } );
			Assert.AreEqual( 3, result.ReadCount );
			Assert.AreEqual( -33L, result.Value );
		}
		
		[Test]
		public void TestUnpackInt32_Stream_NegativeFixNumMinValueMinusOneAsInt16_Fail()
		{
			using ( var buffer = new MemoryStream( new byte[] { 0xD1, 0xFF, 0xDF } ) )
			{
				var result = Unpacking.UnpackInt32( buffer );
				Assert.AreEqual( 3, buffer.Position );
				Assert.AreEqual( -33L, result );
			}
		}
		
		[Test]
		public void TestUnpackInt32_ByteArray_NegativeFixNumMinValueMinusOneAsInt8_Fail()
		{
			var result = Unpacking.UnpackInt32( new byte[] { 0xD0, 0xDF } );
			Assert.AreEqual( 2, result.ReadCount );
			Assert.AreEqual( -33L, result.Value );
		}
		
		[Test]
		public void TestUnpackInt32_Stream_NegativeFixNumMinValueMinusOneAsInt8_Fail()
		{
			using ( var buffer = new MemoryStream( new byte[] { 0xD0, 0xDF } ) )
			{
				var result = Unpacking.UnpackInt32( buffer );
				Assert.AreEqual( 2, buffer.Position );
				Assert.AreEqual( -33L, result );
			}
		}
		
		[Test]
		public void TestUnpackInt32_ByteArray_NegativeFixNumMinValueAsInt64_Fail()
		{
			var result = Unpacking.UnpackInt32( new byte[] { 0xD3, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xE0 } );
			Assert.AreEqual( 9, result.ReadCount );
			Assert.AreEqual( -32L, result.Value );
		}
		
		[Test]
		public void TestUnpackInt32_Stream_NegativeFixNumMinValueAsInt64_Fail()
		{
			using ( var buffer = new MemoryStream( new byte[] { 0xD3, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xE0 } ) )
			{
				var result = Unpacking.UnpackInt32( buffer );
				Assert.AreEqual( 9, buffer.Position );
				Assert.AreEqual( -32L, result );
			}
		}
		
		[Test]
		public void TestUnpackInt32_ByteArray_NegativeFixNumMinValueAsInt32_Fail()
		{
			var result = Unpacking.UnpackInt32( new byte[] { 0xD2, 0xFF, 0xFF, 0xFF, 0xE0 } );
			Assert.AreEqual( 5, result.ReadCount );
			Assert.AreEqual( -32L, result.Value );
		}
		
		[Test]
		public void TestUnpackInt32_Stream_NegativeFixNumMinValueAsInt32_Fail()
		{
			using ( var buffer = new MemoryStream( new byte[] { 0xD2, 0xFF, 0xFF, 0xFF, 0xE0 } ) )
			{
				var result = Unpacking.UnpackInt32( buffer );
				Assert.AreEqual( 5, buffer.Position );
				Assert.AreEqual( -32L, result );
			}
		}
		
		[Test]
		public void TestUnpackInt32_ByteArray_NegativeFixNumMinValueAsInt16_Fail()
		{
			var result = Unpacking.UnpackInt32( new byte[] { 0xD1, 0xFF, 0xE0 } );
			Assert.AreEqual( 3, result.ReadCount );
			Assert.AreEqual( -32L, result.Value );
		}
		
		[Test]
		public void TestUnpackInt32_Stream_NegativeFixNumMinValueAsInt16_Fail()
		{
			using ( var buffer = new MemoryStream( new byte[] { 0xD1, 0xFF, 0xE0 } ) )
			{
				var result = Unpacking.UnpackInt32( buffer );
				Assert.AreEqual( 3, buffer.Position );
				Assert.AreEqual( -32L, result );
			}
		}
		
		[Test]
		public void TestUnpackInt32_ByteArray_NegativeFixNumMinValueAsInt8_Fail()
		{
			var result = Unpacking.UnpackInt32( new byte[] { 0xD0, 0xE0 } );
			Assert.AreEqual( 2, result.ReadCount );
			Assert.AreEqual( -32L, result.Value );
		}
		
		[Test]
		public void TestUnpackInt32_Stream_NegativeFixNumMinValueAsInt8_Fail()
		{
			using ( var buffer = new MemoryStream( new byte[] { 0xD0, 0xE0 } ) )
			{
				var result = Unpacking.UnpackInt32( buffer );
				Assert.AreEqual( 2, buffer.Position );
				Assert.AreEqual( -32L, result );
			}
		}
		
		[Test]
		public void TestUnpackInt32_ByteArray_NegativeFixNumMinValueAsNegativeFixNumMinus32_Fail()
		{
			var result = Unpacking.UnpackInt32( new byte[] { 0xE0 } );
			Assert.AreEqual( 1, result.ReadCount );
			Assert.AreEqual( -32L, result.Value );
		}
		
		[Test]
		public void TestUnpackInt32_Stream_NegativeFixNumMinValueAsNegativeFixNumMinus32_Fail()
		{
			using ( var buffer = new MemoryStream( new byte[] { 0xE0 } ) )
			{
				var result = Unpacking.UnpackInt32( buffer );
				Assert.AreEqual( 1, buffer.Position );
				Assert.AreEqual( -32L, result );
			}
		}
		
		[Test]
		public void TestUnpackInt32_ByteArray_MinusOneAsInt64_Fail()
		{
			var result = Unpacking.UnpackInt32( new byte[] { 0xD3, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF } );
			Assert.AreEqual( 9, result.ReadCount );
			Assert.AreEqual( -1L, result.Value );
		}
		
		[Test]
		public void TestUnpackInt32_Stream_MinusOneAsInt64_Fail()
		{
			using ( var buffer = new MemoryStream( new byte[] { 0xD3, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF } ) )
			{
				var result = Unpacking.UnpackInt32( buffer );
				Assert.AreEqual( 9, buffer.Position );
				Assert.AreEqual( -1L, result );
			}
		}
		
		[Test]
		public void TestUnpackInt32_ByteArray_MinusOneAsInt32_Fail()
		{
			var result = Unpacking.UnpackInt32( new byte[] { 0xD2, 0xFF, 0xFF, 0xFF, 0xFF } );
			Assert.AreEqual( 5, result.ReadCount );
			Assert.AreEqual( -1L, result.Value );
		}
		
		[Test]
		public void TestUnpackInt32_Stream_MinusOneAsInt32_Fail()
		{
			using ( var buffer = new MemoryStream( new byte[] { 0xD2, 0xFF, 0xFF, 0xFF, 0xFF } ) )
			{
				var result = Unpacking.UnpackInt32( buffer );
				Assert.AreEqual( 5, buffer.Position );
				Assert.AreEqual( -1L, result );
			}
		}
		
		[Test]
		public void TestUnpackInt32_ByteArray_MinusOneAsInt16_Fail()
		{
			var result = Unpacking.UnpackInt32( new byte[] { 0xD1, 0xFF, 0xFF } );
			Assert.AreEqual( 3, result.ReadCount );
			Assert.AreEqual( -1L, result.Value );
		}
		
		[Test]
		public void TestUnpackInt32_Stream_MinusOneAsInt16_Fail()
		{
			using ( var buffer = new MemoryStream( new byte[] { 0xD1, 0xFF, 0xFF } ) )
			{
				var result = Unpacking.UnpackInt32( buffer );
				Assert.AreEqual( 3, buffer.Position );
				Assert.AreEqual( -1L, result );
			}
		}
		
		[Test]
		public void TestUnpackInt32_ByteArray_MinusOneAsInt8_Fail()
		{
			var result = Unpacking.UnpackInt32( new byte[] { 0xD0, 0xFF } );
			Assert.AreEqual( 2, result.ReadCount );
			Assert.AreEqual( -1L, result.Value );
		}
		
		[Test]
		public void TestUnpackInt32_Stream_MinusOneAsInt8_Fail()
		{
			using ( var buffer = new MemoryStream( new byte[] { 0xD0, 0xFF } ) )
			{
				var result = Unpacking.UnpackInt32( buffer );
				Assert.AreEqual( 2, buffer.Position );
				Assert.AreEqual( -1L, result );
			}
		}
		
		[Test]
		public void TestUnpackInt32_ByteArray_MinusOneAsNegativeFixNumMinus1_Fail()
		{
			var result = Unpacking.UnpackInt32( new byte[] { 0xFF } );
			Assert.AreEqual( 1, result.ReadCount );
			Assert.AreEqual( -1L, result.Value );
		}
		
		[Test]
		public void TestUnpackInt32_Stream_MinusOneAsNegativeFixNumMinus1_Fail()
		{
			using ( var buffer = new MemoryStream( new byte[] { 0xFF } ) )
			{
				var result = Unpacking.UnpackInt32( buffer );
				Assert.AreEqual( 1, buffer.Position );
				Assert.AreEqual( -1L, result );
			}
		}
		
		[Test]
		public void TestUnpackInt32_ByteArray_ZeroAsInt64_Fail()
		{
			var result = Unpacking.UnpackInt32( new byte[] { 0xD3, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 } );
			Assert.AreEqual( 9, result.ReadCount );
			Assert.AreEqual( 0L, result.Value );
		}
		
		[Test]
		public void TestUnpackInt32_Stream_ZeroAsInt64_Fail()
		{
			using ( var buffer = new MemoryStream( new byte[] { 0xD3, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 } ) )
			{
				var result = Unpacking.UnpackInt32( buffer );
				Assert.AreEqual( 9, buffer.Position );
				Assert.AreEqual( 0L, result );
			}
		}
		
		[Test]
		public void TestUnpackInt32_ByteArray_ZeroAsUInt64_Fail()
		{
			var result = Unpacking.UnpackInt32( new byte[] { 0xCF, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 } );
			Assert.AreEqual( 9, result.ReadCount );
			Assert.AreEqual( 0L, result.Value );
		}
		
		[Test]
		public void TestUnpackInt32_Stream_ZeroAsUInt64_Fail()
		{
			using ( var buffer = new MemoryStream( new byte[] { 0xCF, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 } ) )
			{
				var result = Unpacking.UnpackInt32( buffer );
				Assert.AreEqual( 9, buffer.Position );
				Assert.AreEqual( 0L, result );
			}
		}
		
		[Test]
		public void TestUnpackInt32_ByteArray_ZeroAsInt32_Fail()
		{
			var result = Unpacking.UnpackInt32( new byte[] { 0xD2, 0x00, 0x00, 0x00, 0x00 } );
			Assert.AreEqual( 5, result.ReadCount );
			Assert.AreEqual( 0L, result.Value );
		}
		
		[Test]
		public void TestUnpackInt32_Stream_ZeroAsInt32_Fail()
		{
			using ( var buffer = new MemoryStream( new byte[] { 0xD2, 0x00, 0x00, 0x00, 0x00 } ) )
			{
				var result = Unpacking.UnpackInt32( buffer );
				Assert.AreEqual( 5, buffer.Position );
				Assert.AreEqual( 0L, result );
			}
		}
		
		[Test]
		public void TestUnpackInt32_ByteArray_ZeroAsUInt32_Fail()
		{
			var result = Unpacking.UnpackInt32( new byte[] { 0xCE, 0x00, 0x00, 0x00, 0x00 } );
			Assert.AreEqual( 5, result.ReadCount );
			Assert.AreEqual( 0L, result.Value );
		}
		
		[Test]
		public void TestUnpackInt32_Stream_ZeroAsUInt32_Fail()
		{
			using ( var buffer = new MemoryStream( new byte[] { 0xCE, 0x00, 0x00, 0x00, 0x00 } ) )
			{
				var result = Unpacking.UnpackInt32( buffer );
				Assert.AreEqual( 5, buffer.Position );
				Assert.AreEqual( 0L, result );
			}
		}
		
		[Test]
		public void TestUnpackInt32_ByteArray_ZeroAsInt16_Fail()
		{
			var result = Unpacking.UnpackInt32( new byte[] { 0xD1, 0x00, 0x00 } );
			Assert.AreEqual( 3, result.ReadCount );
			Assert.AreEqual( 0L, result.Value );
		}
		
		[Test]
		public void TestUnpackInt32_Stream_ZeroAsInt16_Fail()
		{
			using ( var buffer = new MemoryStream( new byte[] { 0xD1, 0x00, 0x00 } ) )
			{
				var result = Unpacking.UnpackInt32( buffer );
				Assert.AreEqual( 3, buffer.Position );
				Assert.AreEqual( 0L, result );
			}
		}
		
		[Test]
		public void TestUnpackInt32_ByteArray_ZeroAsUInt16_Fail()
		{
			var result = Unpacking.UnpackInt32( new byte[] { 0xCD, 0x00, 0x00 } );
			Assert.AreEqual( 3, result.ReadCount );
			Assert.AreEqual( 0L, result.Value );
		}
		
		[Test]
		public void TestUnpackInt32_Stream_ZeroAsUInt16_Fail()
		{
			using ( var buffer = new MemoryStream( new byte[] { 0xCD, 0x00, 0x00 } ) )
			{
				var result = Unpacking.UnpackInt32( buffer );
				Assert.AreEqual( 3, buffer.Position );
				Assert.AreEqual( 0L, result );
			}
		}
		
		[Test]
		public void TestUnpackInt32_ByteArray_ZeroAsInt8_Fail()
		{
			var result = Unpacking.UnpackInt32( new byte[] { 0xD0, 0x00 } );
			Assert.AreEqual( 2, result.ReadCount );
			Assert.AreEqual( 0L, result.Value );
		}
		
		[Test]
		public void TestUnpackInt32_Stream_ZeroAsInt8_Fail()
		{
			using ( var buffer = new MemoryStream( new byte[] { 0xD0, 0x00 } ) )
			{
				var result = Unpacking.UnpackInt32( buffer );
				Assert.AreEqual( 2, buffer.Position );
				Assert.AreEqual( 0L, result );
			}
		}
		
		[Test]
		public void TestUnpackInt32_ByteArray_ZeroAsUInt8_Fail()
		{
			var result = Unpacking.UnpackInt32( new byte[] { 0xCC, 0x00 } );
			Assert.AreEqual( 2, result.ReadCount );
			Assert.AreEqual( 0L, result.Value );
		}
		
		[Test]
		public void TestUnpackInt32_Stream_ZeroAsUInt8_Fail()
		{
			using ( var buffer = new MemoryStream( new byte[] { 0xCC, 0x00 } ) )
			{
				var result = Unpacking.UnpackInt32( buffer );
				Assert.AreEqual( 2, buffer.Position );
				Assert.AreEqual( 0L, result );
			}
		}
		
		[Test]
		public void TestUnpackInt32_ByteArray_ZeroAsPositiveFixNum0_Fail()
		{
			var result = Unpacking.UnpackInt32( new byte[] { 0x00 } );
			Assert.AreEqual( 1, result.ReadCount );
			Assert.AreEqual( 0L, result.Value );
		}
		
		[Test]
		public void TestUnpackInt32_Stream_ZeroAsPositiveFixNum0_Fail()
		{
			using ( var buffer = new MemoryStream( new byte[] { 0x00 } ) )
			{
				var result = Unpacking.UnpackInt32( buffer );
				Assert.AreEqual( 1, buffer.Position );
				Assert.AreEqual( 0L, result );
			}
		}
		
		[Test]
		public void TestUnpackInt32_ByteArray_PlusOneAsInt64_Fail()
		{
			var result = Unpacking.UnpackInt32( new byte[] { 0xD3, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x01 } );
			Assert.AreEqual( 9, result.ReadCount );
			Assert.AreEqual( 1L, result.Value );
		}
		
		[Test]
		public void TestUnpackInt32_Stream_PlusOneAsInt64_Fail()
		{
			using ( var buffer = new MemoryStream( new byte[] { 0xD3, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x01 } ) )
			{
				var result = Unpacking.UnpackInt32( buffer );
				Assert.AreEqual( 9, buffer.Position );
				Assert.AreEqual( 1L, result );
			}
		}
		
		[Test]
		public void TestUnpackInt32_ByteArray_PlusOneAsUInt64_Fail()
		{
			var result = Unpacking.UnpackInt32( new byte[] { 0xCF, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x01 } );
			Assert.AreEqual( 9, result.ReadCount );
			Assert.AreEqual( 1L, result.Value );
		}
		
		[Test]
		public void TestUnpackInt32_Stream_PlusOneAsUInt64_Fail()
		{
			using ( var buffer = new MemoryStream( new byte[] { 0xCF, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x01 } ) )
			{
				var result = Unpacking.UnpackInt32( buffer );
				Assert.AreEqual( 9, buffer.Position );
				Assert.AreEqual( 1L, result );
			}
		}
		
		[Test]
		public void TestUnpackInt32_ByteArray_PlusOneAsInt32_Fail()
		{
			var result = Unpacking.UnpackInt32( new byte[] { 0xD2, 0x00, 0x00, 0x00, 0x01 } );
			Assert.AreEqual( 5, result.ReadCount );
			Assert.AreEqual( 1L, result.Value );
		}
		
		[Test]
		public void TestUnpackInt32_Stream_PlusOneAsInt32_Fail()
		{
			using ( var buffer = new MemoryStream( new byte[] { 0xD2, 0x00, 0x00, 0x00, 0x01 } ) )
			{
				var result = Unpacking.UnpackInt32( buffer );
				Assert.AreEqual( 5, buffer.Position );
				Assert.AreEqual( 1L, result );
			}
		}
		
		[Test]
		public void TestUnpackInt32_ByteArray_PlusOneAsUInt32_Fail()
		{
			var result = Unpacking.UnpackInt32( new byte[] { 0xCE, 0x00, 0x00, 0x00, 0x01 } );
			Assert.AreEqual( 5, result.ReadCount );
			Assert.AreEqual( 1L, result.Value );
		}
		
		[Test]
		public void TestUnpackInt32_Stream_PlusOneAsUInt32_Fail()
		{
			using ( var buffer = new MemoryStream( new byte[] { 0xCE, 0x00, 0x00, 0x00, 0x01 } ) )
			{
				var result = Unpacking.UnpackInt32( buffer );
				Assert.AreEqual( 5, buffer.Position );
				Assert.AreEqual( 1L, result );
			}
		}
		
		[Test]
		public void TestUnpackInt32_ByteArray_PlusOneAsInt16_Fail()
		{
			var result = Unpacking.UnpackInt32( new byte[] { 0xD1, 0x00, 0x01 } );
			Assert.AreEqual( 3, result.ReadCount );
			Assert.AreEqual( 1L, result.Value );
		}
		
		[Test]
		public void TestUnpackInt32_Stream_PlusOneAsInt16_Fail()
		{
			using ( var buffer = new MemoryStream( new byte[] { 0xD1, 0x00, 0x01 } ) )
			{
				var result = Unpacking.UnpackInt32( buffer );
				Assert.AreEqual( 3, buffer.Position );
				Assert.AreEqual( 1L, result );
			}
		}
		
		[Test]
		public void TestUnpackInt32_ByteArray_PlusOneAsUInt16_Fail()
		{
			var result = Unpacking.UnpackInt32( new byte[] { 0xCD, 0x00, 0x01 } );
			Assert.AreEqual( 3, result.ReadCount );
			Assert.AreEqual( 1L, result.Value );
		}
		
		[Test]
		public void TestUnpackInt32_Stream_PlusOneAsUInt16_Fail()
		{
			using ( var buffer = new MemoryStream( new byte[] { 0xCD, 0x00, 0x01 } ) )
			{
				var result = Unpacking.UnpackInt32( buffer );
				Assert.AreEqual( 3, buffer.Position );
				Assert.AreEqual( 1L, result );
			}
		}
		
		[Test]
		public void TestUnpackInt32_ByteArray_PlusOneAsInt8_Fail()
		{
			var result = Unpacking.UnpackInt32( new byte[] { 0xD0, 0x01 } );
			Assert.AreEqual( 2, result.ReadCount );
			Assert.AreEqual( 1L, result.Value );
		}
		
		[Test]
		public void TestUnpackInt32_Stream_PlusOneAsInt8_Fail()
		{
			using ( var buffer = new MemoryStream( new byte[] { 0xD0, 0x01 } ) )
			{
				var result = Unpacking.UnpackInt32( buffer );
				Assert.AreEqual( 2, buffer.Position );
				Assert.AreEqual( 1L, result );
			}
		}
		
		[Test]
		public void TestUnpackInt32_ByteArray_PlusOneAsUInt8_Fail()
		{
			var result = Unpacking.UnpackInt32( new byte[] { 0xCC, 0x01 } );
			Assert.AreEqual( 2, result.ReadCount );
			Assert.AreEqual( 1L, result.Value );
		}
		
		[Test]
		public void TestUnpackInt32_Stream_PlusOneAsUInt8_Fail()
		{
			using ( var buffer = new MemoryStream( new byte[] { 0xCC, 0x01 } ) )
			{
				var result = Unpacking.UnpackInt32( buffer );
				Assert.AreEqual( 2, buffer.Position );
				Assert.AreEqual( 1L, result );
			}
		}
		
		[Test]
		public void TestUnpackInt32_ByteArray_PlusOneAsPositiveFixNum1_Fail()
		{
			var result = Unpacking.UnpackInt32( new byte[] { 0x01 } );
			Assert.AreEqual( 1, result.ReadCount );
			Assert.AreEqual( 1L, result.Value );
		}
		
		[Test]
		public void TestUnpackInt32_Stream_PlusOneAsPositiveFixNum1_Fail()
		{
			using ( var buffer = new MemoryStream( new byte[] { 0x01 } ) )
			{
				var result = Unpacking.UnpackInt32( buffer );
				Assert.AreEqual( 1, buffer.Position );
				Assert.AreEqual( 1L, result );
			}
		}
		
		[Test]
		public void TestUnpackInt32_ByteArray_PositiveFixNumMaxValueAsInt64_Fail()
		{
			var result = Unpacking.UnpackInt32( new byte[] { 0xD3, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x7F } );
			Assert.AreEqual( 9, result.ReadCount );
			Assert.AreEqual( 127L, result.Value );
		}
		
		[Test]
		public void TestUnpackInt32_Stream_PositiveFixNumMaxValueAsInt64_Fail()
		{
			using ( var buffer = new MemoryStream( new byte[] { 0xD3, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x7F } ) )
			{
				var result = Unpacking.UnpackInt32( buffer );
				Assert.AreEqual( 9, buffer.Position );
				Assert.AreEqual( 127L, result );
			}
		}
		
		[Test]
		public void TestUnpackInt32_ByteArray_PositiveFixNumMaxValueAsUInt64_Fail()
		{
			var result = Unpacking.UnpackInt32( new byte[] { 0xCF, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x7F } );
			Assert.AreEqual( 9, result.ReadCount );
			Assert.AreEqual( 127L, result.Value );
		}
		
		[Test]
		public void TestUnpackInt32_Stream_PositiveFixNumMaxValueAsUInt64_Fail()
		{
			using ( var buffer = new MemoryStream( new byte[] { 0xCF, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x7F } ) )
			{
				var result = Unpacking.UnpackInt32( buffer );
				Assert.AreEqual( 9, buffer.Position );
				Assert.AreEqual( 127L, result );
			}
		}
		
		[Test]
		public void TestUnpackInt32_ByteArray_PositiveFixNumMaxValueAsInt32_Fail()
		{
			var result = Unpacking.UnpackInt32( new byte[] { 0xD2, 0x00, 0x00, 0x00, 0x7F } );
			Assert.AreEqual( 5, result.ReadCount );
			Assert.AreEqual( 127L, result.Value );
		}
		
		[Test]
		public void TestUnpackInt32_Stream_PositiveFixNumMaxValueAsInt32_Fail()
		{
			using ( var buffer = new MemoryStream( new byte[] { 0xD2, 0x00, 0x00, 0x00, 0x7F } ) )
			{
				var result = Unpacking.UnpackInt32( buffer );
				Assert.AreEqual( 5, buffer.Position );
				Assert.AreEqual( 127L, result );
			}
		}
		
		[Test]
		public void TestUnpackInt32_ByteArray_PositiveFixNumMaxValueAsUInt32_Fail()
		{
			var result = Unpacking.UnpackInt32( new byte[] { 0xCE, 0x00, 0x00, 0x00, 0x7F } );
			Assert.AreEqual( 5, result.ReadCount );
			Assert.AreEqual( 127L, result.Value );
		}
		
		[Test]
		public void TestUnpackInt32_Stream_PositiveFixNumMaxValueAsUInt32_Fail()
		{
			using ( var buffer = new MemoryStream( new byte[] { 0xCE, 0x00, 0x00, 0x00, 0x7F } ) )
			{
				var result = Unpacking.UnpackInt32( buffer );
				Assert.AreEqual( 5, buffer.Position );
				Assert.AreEqual( 127L, result );
			}
		}
		
		[Test]
		public void TestUnpackInt32_ByteArray_PositiveFixNumMaxValueAsInt16_Fail()
		{
			var result = Unpacking.UnpackInt32( new byte[] { 0xD1, 0x00, 0x7F } );
			Assert.AreEqual( 3, result.ReadCount );
			Assert.AreEqual( 127L, result.Value );
		}
		
		[Test]
		public void TestUnpackInt32_Stream_PositiveFixNumMaxValueAsInt16_Fail()
		{
			using ( var buffer = new MemoryStream( new byte[] { 0xD1, 0x00, 0x7F } ) )
			{
				var result = Unpacking.UnpackInt32( buffer );
				Assert.AreEqual( 3, buffer.Position );
				Assert.AreEqual( 127L, result );
			}
		}
		
		[Test]
		public void TestUnpackInt32_ByteArray_PositiveFixNumMaxValueAsUInt16_Fail()
		{
			var result = Unpacking.UnpackInt32( new byte[] { 0xCD, 0x00, 0x7F } );
			Assert.AreEqual( 3, result.ReadCount );
			Assert.AreEqual( 127L, result.Value );
		}
		
		[Test]
		public void TestUnpackInt32_Stream_PositiveFixNumMaxValueAsUInt16_Fail()
		{
			using ( var buffer = new MemoryStream( new byte[] { 0xCD, 0x00, 0x7F } ) )
			{
				var result = Unpacking.UnpackInt32( buffer );
				Assert.AreEqual( 3, buffer.Position );
				Assert.AreEqual( 127L, result );
			}
		}
		
		[Test]
		public void TestUnpackDictionary_Stream_Map16MaxValue_AsMap16_AsIs()
		{
			{
				var result = Unpacking.UnpackDictionary( buffer );
				Assert.AreEqual( 393213, buffer.Position );
				Assert.AreEqual( 0xFFFF, result.Count );
				for ( int i = 0; i < result.Count; i++ )
				{
					MessagePackObject value;
					Assert.IsTrue( result.TryGetValue( i + 1, out value ) );
					Assert.IsTrue( value.Equals( 0x57 ) );
				}
			}
		}	
	}
}