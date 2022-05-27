using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EV3_Examen_Ejercicio_02.Models
{
    public class ConfigModel
    {
      
        public bool Enabled { get; set; }
        
        private FileMode _modeForCreatingFiles { get; set; }
        public FileMode RawModeForCreatingFiles
        {
            get
            {
                return _modeForCreatingFiles;
            }
            set
            {
                this._modeForCreatingFiles = value;
            }
        }

        public string ModeForCreatingFiles
        {
            get
            {
                return !string.IsNullOrWhiteSpace(this._modeForCreatingFiles.ToString()) ? this._modeForCreatingFiles.ToString() : string.Empty;
                
            }
            set
            {
                this._modeForCreatingFiles = (FileMode)Enum.Parse(typeof(FileMode), value);
            }
        }




        private DateTime _nextBackup { get; set; }
        public DateTime RawNextBackup
        {
            get
            {
                return this._nextBackup;
            }
            set
            {
                this._nextBackup = value;
            }

        }
        public string NextBackup
        {
            get
            {
                return this._nextBackup != null ? this._nextBackup.ToString() : string.Empty;
            }
            set
            {
                this._nextBackup = DateTime.Parse(value);
            }
        }


    }
}
