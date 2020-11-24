﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (https://www.specflow.org/).
//      SpecFlow Version:3.5.0.0
//      SpecFlow Generator Version:3.5.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace OtomatikMuhendis.Cognitive.Face.Specs.Features
{
    using TechTalk.SpecFlow;
    using System;
    using System.Linq;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.5.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public partial class SokağaCıkmaKısıtlamasıFeature : object, Xunit.IClassFixture<SokağaCıkmaKısıtlamasıFeature.FixtureData>, System.IDisposable
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
        private string[] _featureTags = ((string[])(null));
        
        private Xunit.Abstractions.ITestOutputHelper _testOutputHelper;
        
#line 1 "CurfewService.feature"
#line hidden
        
        public SokağaCıkmaKısıtlamasıFeature(SokağaCıkmaKısıtlamasıFeature.FixtureData fixtureData, OtomatikMuhendis_Cognitive_Face_Specs_XUnitAssemblyFixture assemblyFixture, Xunit.Abstractions.ITestOutputHelper testOutputHelper)
        {
            this._testOutputHelper = testOutputHelper;
            this.TestInitialize();
        }
        
        public static void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("tr"), "Features", "Sokağa çıkma kısıtlaması", null, ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        public static void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        public virtual void TestInitialize()
        {
        }
        
        public virtual void TestTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioInitialize(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioInitialize(scenarioInfo);
            testRunner.ScenarioContext.ScenarioContainer.RegisterInstanceAs<Xunit.Abstractions.ITestOutputHelper>(_testOutputHelper);
        }
        
        public virtual void ScenarioStart()
        {
            testRunner.OnScenarioStart();
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        void System.IDisposable.Dispose()
        {
            this.TestTearDown();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="Kanım kaynıyor")]
        [Xunit.TraitAttribute("FeatureTitle", "Sokağa çıkma kısıtlaması")]
        [Xunit.TraitAttribute("Description", "Kanım kaynıyor")]
        public virtual void KanımKaynıyor()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Kanım kaynıyor", null, tagsOfScenario, argumentsOfScenario);
#line 4
this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 5
 testRunner.Given("19 yaşındayım", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Diyelim ki ");
#line hidden
#line 6
 testRunner.And("günlerden Cumartesi", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Ve ");
#line hidden
#line 7
 testRunner.But("saat 21", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Fakat ");
#line hidden
#line 8
 testRunner.When("dışarı çıkmak istersem", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Eğer ki ");
#line hidden
#line 9
 testRunner.Then("çıkamam", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "O zaman ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="Babam bakkala git dedi")]
        [Xunit.TraitAttribute("FeatureTitle", "Sokağa çıkma kısıtlaması")]
        [Xunit.TraitAttribute("Description", "Babam bakkala git dedi")]
        public virtual void BabamBakkalaGitDedi()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Babam bakkala git dedi", null, tagsOfScenario, argumentsOfScenario);
#line 11
this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 12
 testRunner.Given("12 yaşındayım", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Diyelim ki ");
#line hidden
#line 13
 testRunner.And("günlerden Pazartesi", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Ve ");
#line hidden
#line 14
 testRunner.And("saat 14", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Ve ");
#line hidden
#line 15
 testRunner.When("dışarı çıkmak istersem", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Eğer ki ");
#line hidden
#line 16
 testRunner.Then("çıkabilirim", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "O zaman ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="Şöyle bir hava alayım")]
        [Xunit.TraitAttribute("FeatureTitle", "Sokağa çıkma kısıtlaması")]
        [Xunit.TraitAttribute("Description", "Şöyle bir hava alayım")]
        public virtual void SoyleBirHavaAlayım()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Şöyle bir hava alayım", null, tagsOfScenario, argumentsOfScenario);
#line 18
this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 19
 testRunner.Given("72 yaşındayım", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Diyelim ki ");
#line hidden
#line 20
 testRunner.And("günlerden Cuma", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Ve ");
#line hidden
#line 21
 testRunner.And("saat 11", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Ve ");
#line hidden
#line 22
 testRunner.When("dışarı çıkmak istersem", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Eğer ki ");
#line hidden
#line 23
 testRunner.Then("çıkabilirim", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "O zaman ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="Otur otur bunaldım")]
        [Xunit.TraitAttribute("FeatureTitle", "Sokağa çıkma kısıtlaması")]
        [Xunit.TraitAttribute("Description", "Otur otur bunaldım")]
        public virtual void OturOturBunaldım()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Otur otur bunaldım", null, tagsOfScenario, argumentsOfScenario);
#line 25
this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 26
 testRunner.Given("66 yaşındayım", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Diyelim ki ");
#line hidden
#line 27
 testRunner.And("günlerden Salı", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Ve ");
#line hidden
#line 28
 testRunner.And("saat 14", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Ve ");
#line hidden
#line 29
 testRunner.When("dışarı çıkmak istersem", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Eğer ki ");
#line hidden
#line 30
 testRunner.Then("çıkamam", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "O zaman ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="Sahile ineyim")]
        [Xunit.TraitAttribute("FeatureTitle", "Sokağa çıkma kısıtlaması")]
        [Xunit.TraitAttribute("Description", "Sahile ineyim")]
        public virtual void SahileIneyim()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Sahile ineyim", null, tagsOfScenario, argumentsOfScenario);
#line 32
this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 33
 testRunner.Given("35 yaşındayım", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Diyelim ki ");
#line hidden
#line 34
 testRunner.And("günlerden Cumartesi", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Ve ");
#line hidden
#line 35
 testRunner.And("saat 16", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Ve ");
#line hidden
#line 36
 testRunner.When("dışarı çıkmak istersem", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Eğer ki ");
#line hidden
#line 37
 testRunner.Then("çıkabilirim", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "O zaman ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="Ben sana erken kalkalım dedim")]
        [Xunit.TraitAttribute("FeatureTitle", "Sokağa çıkma kısıtlaması")]
        [Xunit.TraitAttribute("Description", "Ben sana erken kalkalım dedim")]
        public virtual void BenSanaErkenKalkalımDedim()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Ben sana erken kalkalım dedim", null, tagsOfScenario, argumentsOfScenario);
#line 39
this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 40
 testRunner.Given("46 yaşındayım", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Diyelim ki ");
#line hidden
#line 41
 testRunner.And("günlerden Pazar", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Ve ");
#line hidden
#line 42
 testRunner.But("saat 21", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Ama ");
#line hidden
#line 43
 testRunner.When("dışarı çıkmak istersem", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Eğer ki ");
#line hidden
#line 44
 testRunner.Then("çıkamam", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "O zaman ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.5.0.0")]
        [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
        public class FixtureData : System.IDisposable
        {
            
            public FixtureData()
            {
                SokağaCıkmaKısıtlamasıFeature.FeatureSetup();
            }
            
            void System.IDisposable.Dispose()
            {
                SokağaCıkmaKısıtlamasıFeature.FeatureTearDown();
            }
        }
    }
}
#pragma warning restore
#endregion
