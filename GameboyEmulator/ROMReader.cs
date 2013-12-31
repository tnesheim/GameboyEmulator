using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace GameboyEmulator
{
    /// <summary>
    /// Class used to read in a rom file from disk into a byte array to be used by 
    /// an appropriate emulator.
    /// </summary>
    class ROMReader
    {
        private string romPath;
        private byte[] romData;

        /// <summary>
        /// Creates a new ROMReader.
        /// </summary>
        /// <param name="filePath">The filepath to the ROM to be read in</param>
        public ROMReader(string filePath)
        {
            this.romPath = filePath;
        }

        /// <summary>
        /// Reads the ROM at the specified filepath 
        /// </summary>
        public void readROM()
        {
            try
            {
                /*Read all of the ROM data into the byte array*/
                this.romData = File.ReadAllBytes(this.romPath);          
            }
            catch (ArgumentException)
            {
                //Path is empty string
            }
            catch (FileNotFoundException)
            {
                //File was not found
            }
            catch (DirectoryNotFoundException)
            { 
                //Part of the directory unmappable 
            }
            catch (IOException)
            {
                //Do stuff to solve this
            }
            catch (Exception)
            {
                //Unknown exception
            }
        }

        /// <summary>
        /// Property used to access the byte array containing the requested ROM.
        /// </summary>
        public byte[] RomData
        {
            get
            {
                return romData;
            }
        }
    }
}
