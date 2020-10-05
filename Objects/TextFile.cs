using System;
using System.IO;
using System.Xml.Serialization;

namespace NetPad.Objects
{
    public class TextFile
    {
        /// <summary>
        /// Chemin d'accès et nom du fichier.
        /// </summary>
        [XmlAttribute(AttributeName = "Filename")]
        public string FileName { get; set; }

        /// <summary>
        /// chemin d'accs et nom du fichier backup.
        /// </summary>]
        [XmlAttribute(AttributeName = "BackupFileName")]
        public string BackupFileName { get; set; } = string.Empty;

        /// <summary>
        /// Nom et extension du fichier. Le nom du fichier n'inclut pas le chemin d'accès.
        /// </summary>
        [XmlIgnore]
        public string SafeFileName { get; set; }

        /// <summary>
        /// Nom et extension du fichier backup. Le nom du fichier n'inclut pas le chemin d'accès.
        /// </summary>
        [XmlIgnore]
        public string SafeBackupFileName { get; set; }

        /// <summary>
        /// Contenu du fichier
        /// </summary>
        [XmlIgnore]
        public string Contend { get; set; } = string.Empty;


        /// <summary>
        /// Contructeur de la classe TextFile.
        /// </summary>
        public TextFile()
        {

        }

        /// <summary>
        /// Constructeur de la classe TestFile
        /// </summary>
        /// <param name="fileName">Chemin d'accès et nom du fichier.</param>
        public TextFile(string fileName)
        {
            FileName = fileName;
            SafeFileName = Path.GetFileName(fileName);

            if (fileName.StartsWith("Sans Titre"))
            {
                SafeBackupFileName = $"{fileName}@{DateTime.Now:dd-MM-yyyy-HH-mm-ss}";
                BackupFileName = Path.Combine(Session.BackupPath, SafeBackupFileName);
            }
        }
    }
}
