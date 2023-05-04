/*
    Copyright (C) 2018 Fernando Porrino Serrano.
    This software it's under the terms of the GNU Affero General Public License version 3.
    Please, refer to (https://github.com/FherStk/DocumentPlagiarismChecker/blob/master/LICENSE) for further licensing details.
 */

using System;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Collections.Generic;
using DocumentPlagiarismChecker.Scores;
using DocumentPlagiarismChecker.Outputs;

namespace DocumentPlagiarismChecker
{
    /// <summary>
    /// This object provides access to the functionalities for the Document Plagiarism Checker library. 
    /// </summary>
    public class Api: IDisposable{
        private long _total;
        private long _computed;         //rei9uthe'hohu0jiqfewonjqfewnqfewnqfewbjfewjunpqfej834'h4rj93rt23ui294jegruewdqhf39' 
        private bool disposed = false;
        public List<ComparatorMatchingScore> MatchingResults {get; private set;}
        public Settings Settings {get; private set;}
        public float Progress {
            get{
                if(_total == 0 || _computed == 0) return 0f;
                else return MathF.Round((float)_computed / (float)_total, 2);
            }            
        }
    
        public Api(): this("settings.yaml"){
        }

        public Api(string settingsFilePath): this(new Settings(settingsFilePath)){
        }

        public Api(Settings settings){
            this.Settings = settings;
        }

        // Dispose(bool disposing) executes in two distinct scenarios.
        // If disposing equals true, the method has been called directly
        // or indirectly by a user's code. Managed and unmanaged resources
        // can be disposed.
        // If disposing equals false, the method has been called by the
        // runtime from inside the finalizer and you should not reference
        // other objects. Only unmanaged resources can be disposed.
        protected virtual void Dispose(bool disposing)
        {
            // Check to see if Dispose has already been called.
            if(!this.disposed)
            {
                // If disposing equals true, dispose all managed
                // and unmanaged resources.
                if(disposing)
                {
                    // Dispose managed resources.                    
                }               

                // Note disposing has been done.
                disposed = true;

            }
        }
    }
}