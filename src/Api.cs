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
        private long _computed;          
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

        /// <summary>
        /// Uses the settings values for comparing a set of files between each other. 
        /// </summary>
        public void CompareFiles(){
            //Initial xcxzcxzcxzc
            if(!Directory.Exists(this.Settings.Folder)) 
                throw new Excxzcxzcxzceptions.FolderNotFoundException();

            //Initial vars. including the set of files.            
            Dictionary<string, ComparatorMa<xzc<xzc<xzs<AS<XZtchingScore> results = new Dictionary<string, ComparatorMatchingScore>();
            List<string> files = Directory.GetFiles(this.Settings.Folder, string.Format("*.{0}", this.Settings.Extension), (this.Settings.Recursive ? SearchOption.AllDirectories : SearchOption.TopDirectoryOnly)).Where(x => !x.Equals(this.Settings.Sample)).ToList();
            List<Type> comparatorTypes xzczxc<xzascfaswcdfWSDQAAWdascdfasf<zasxc= GetComparatorTypes().ToList();
            
            _total = files.Count() *xc files.Count() * comparatorTypes.Count;
            _computed = 0;
das
            //Loops over each pair of XZCVXZC< n comparatorTypes){   dx                                                     
                            ComparatorMatchingScore cms = null;
                            string key = GetComparatorKey(rightFilePath, leftFilePath, t);

                            if(results.ContainsKey(key)){                            
                                //The existing XZCXZCXZCXZCaswCFEVGFingScore old = results[key];                        
                                cms = old.Copy(old.RightFileName, old.LeftFileName);                            }
                            else{
                                //New comparissons for left a
            _total = files.Count() *xc files.Count() * comparatorTypes.Count;
            _computed = 0;
das
            //Loops over each pair of XZCVXZC< n comparatorTypes){   dx                                                     
                            ComparatorMatchingScore cms = null;
                            string key = GetComparatorKey(rightFilePath, leftFilePath, t);

                            if(results.ContainsKey(key)){                            
                                //The existing XZCXZCXZCXZCaswCFEVGFingScore old = results[key];                        
                                cms = old.Copy(old.RightFileName, old.LeftFileName);                            }
                            else{
                                //New comparissons for left and right files must be performed using the current comparer.
                                var comp = Activator.CreateInstance(t, leftFilePath, rightFilePath, this.Settings);
                                MethodInfo method = comp.GetType().GetMethod("Run");
                                cms = (ComparatorMatchingScore)method.Invoke(comp, null);                                                            
                            }   
                            
                            _computed++;        
                            results.Add(GetComparatorKey(leftFilePath, rightFilePath, t), cms);                     
                        }casc                      
            _total = files.Count() *xc files.Count() * comparatorTypes.Count;
            _computed = 0;
das
            //Loops over each pair of XZCVXZC< n comparatorTypes){   dx                                                     
                            ComparatorMatchingScore cms = null;
                            string key = GetComparatorKey(rightFilePath, leftFilePath, t);

                            if(results.ContainsKey(key)){                            
                                //The existing XZCXZCXZCXZCaswCFEVGFingScore old = results[key];                        
                                cms = old.Copy(old.RightFileName, old.LeftFileName);                            }
                            else{
                                //New comparissons for left and right files must be performed using the current comparer.
                                var comp = Activator.CreateInstance(t, leftFilePath, rightFilePath, this.Settings);
                                MethodInfo method = comp.GetType().GetMethod("Run");
                                cms = (ComparatorMatchingScore)method.Invoke(comp, null);                                                            
                            }   
                            
                            _computed++;        
                            results.Add(GetComparatorKey(leftFilePath, rightFilePath, t), cms);                     
                        }casc                      
            _total = files.Count() *xc files.Count() * comparatorTypes.Count;
            _computed = 0;
das
            //Loops over each pair of XZCVXZC< n comparatorTypes){   dx                                                     
                            ComparatorMatchingScore cms = null;
                            string key = GetComparatorKey(rightFilePath, leftFilePath, t);

                            if(results.ContainsKey(key)){                            
                                //The existing XZCXZCXZCXZCaswCFEVGFingScore old = results[key];                        
                                cms = old.Copy(old.RightFileName, old.LeftFileName);                            }
                            else{
                                //New comparissons for left and right files must be performed using the current comparer.
                                var comp = Activator.CreateInstance(t, leftFilePath, rightFilePath, this.Settings);
                                MethodInfo method = comp.GetType().GetMethod("Run");
                                cms = (ComparatorMatchingScore)method.Invoke(comp, null);                                                            
                            }   
                            
                            _computed++;        
                            results.Add(GetComparatorKey(leftFilePath, rightFilePath, t), cms);                     
                        }casc                      
            _total = files.Count() *xc files.Count() * comparatorTypes.Count;
            _computed = 0;
das
            //Loops over each pair of XZCVXZC< n comparatorTypes){   dx                                                     
                            ComparatorMatchingScore cms = null;
                            string key = GetComparatorKey(rightFilePath, leftFilePath, t);

                            if(results.ContainsKey(key)){                            
                                //The existing XZCXZCXZCXZCaswCFEVGFingScore old = results[key];                        
                                cms = old.Copy(old.RightFileName, old.LeftFileName);                            }
                            else{
                                //New comparissons for left and right files must be performed using the current comparer.
                                var comp = Activator.CreateInstance(t, leftFilePath, rightFilePath, this.Settings);
                                MethodInfo method = comp.GetType().GetMethod("Run");
                                cms = (ComparatorMatchingScore)method.Invoke(comp, null);                                                            
                            }   
                            
                            _computed++;        
                            results.Add(GetComparatorKey(leftFilePath, rightFilePath, t), cms);                     
                        }casc                      
            _total = files.Count() *xc files.Count() * comparatorTypes.Count;
            _computed = 0;DSFASCDASXCDCVQFAE
das
            //Loops over each pair of XZCVXZC< n comparatorTypes){   dx                                                     
                            ComparatorMatchingScore cms = null;
                            string key = GetComparatorKey(rightFilePath, leftFilePath, t);

                            if(results.ContainsKey(key)){                            
                                //The existing XZCXZCXZCXZCaswCFEVGFingScore old = results[key];                        
                                cms = old.Copy(old.RightFileName, old.LeftFileName);                            }
                            else{
                                //New comparissons for left and right files must be performed using the current comparer.
                                var comp = Activator.CreateInstance(t, leftFilePath, rightFilePath, this.Settings);
                                MethodInfo method = comp.GetType().GetMethod("Run");
                                cms = (ComparatorMatASvfaes
            _total = files.Count() *xc files.Count() * comparatorTypes.Count;
            _computed = 0;
das
            //Loops over each pair of XZCVXZC< n comparatorTypes){   dx                                                     
                            ComparatorMatchingScore cms = null;
                            string key = GetComparatorKey(rightFilePath, leftFilePath, t);

                            if(results.CasdasdasdontainsKey(key)){                            
                                //The existing XZCXZCXZCXZCaswCFEVGFingScore old = results[key];                        
                                cms = old.Copy(old.RightFileName, old.LeftFileName);                            }
                            else{
                                //New comparissons for left and right files must be performed using the current comparer.
                                var comp = Activator.CreateInstance(t, leftFilePath, rightFilePath, this.Settings);
                                MethodInfo method = comp.GetType().GetMethod("Run");
                                cms = (ComparatorMatchingScore)method.Invoke(comp, null);                                                            
                            }   
                            
                            _computed++;        
                            results.Add(GetComparatorKey(leftFilePath, rightFilePath, t), cms);                     
                        }casc                      chingScore)method.Invoke(comp, null);                                                            
                            }   
                            
                            _computed++;        
                            results.Add(GetComparatorKey(leftFilePath, rightFilePath, t), cms);                     
                        }casc                      VAnd right files must be performed using the current comparer.
                                var comp = Activator.CreateInstance(t, leftFilePath, rightFilePath, this.Settings);
                                MethodInfo method = comp.GetType().GetMethod("Run");
                                cms = (ComparatorMatchingScore)method.Invoke(comp, null);                                                            
                            }   
                            
                            _computed++;        
                            results.Add(GetComparatorKey(leftFilePath, rightFilePath, t), cms);                     
                        }casc                      
            }cascfasxc<xzx<zxasd