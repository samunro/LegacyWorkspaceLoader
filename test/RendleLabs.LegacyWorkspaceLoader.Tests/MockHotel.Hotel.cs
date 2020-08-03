﻿namespace RendleLabs.AdhocWorkspaceLoader.Tests
{
    internal static partial class MockHotel
    {
        public static class Hotel
        {
            public const string Directory = @"D:\Hotel\Hotel";
            public const string FilePath = @"D:\Hotel\Hotel\Hotel.csproj";

            public const string Csproj =
                @"<Project ToolsVersion=""15.0"" DefaultTargets=""Build"" xmlns=""http://schemas.microsoft.com/developer/msbuild/2003"">
  <Import Project=""$(MSBuildExtensionsPath)\$(MSBuildToolsVersion)\Microsoft.Common.props"" Condition=""Exists('$(MSBuildExtensionsPath)\$(MSBuildToolsVersion)\Microsoft.Common.props')"" />
  <PropertyGroup>
    <Configuration Condition="" '$(Configuration)' == '' "">Debug</Configuration>
    <Platform Condition="" '$(Platform)' == '' "">AnyCPU</Platform>
    <ProductVersion>
    </ProductVersion>
    <SchemaVersion>2.0</SchemaVersion>
    <ProjectGuid>{0AB9EB14-38A1-40FD-B093-B756E9679FE5}</ProjectGuid>
    <ProjectTypeGuids>{349c5851-65df-11da-9384-00065b846f21};{fae04ec0-301f-11d3-bf4b-00c04f79efbc}</ProjectTypeGuids>
    <OutputType>Library</OutputType>
    <AppDesignerFolder>Properties</AppDesignerFolder>
    <RootNamespace>Hotel</RootNamespace>
    <AssemblyName>Hotel</AssemblyName>
    <TargetFrameworkVersion>v4.7.2</TargetFrameworkVersion>
    <WcfConfigValidationEnabled>True</WcfConfigValidationEnabled>
    <AutoGenerateBindingRedirects>true</AutoGenerateBindingRedirects>
    <UseIISExpress>true</UseIISExpress>
    <Use64BitIISExpress />
    <IISExpressSSLPort />
    <IISExpressAnonymousAuthentication />
    <IISExpressWindowsAuthentication />
    <IISExpressUseClassicPipelineMode />
    <UseGlobalApplicationHostFile />
  </PropertyGroup>
  <PropertyGroup Condition="" '$(Configuration)|$(Platform)' == 'Debug|AnyCPU' "">
    <DebugSymbols>true</DebugSymbols>
    <DebugType>full</DebugType>
    <Optimize>false</Optimize>
    <OutputPath>bin\</OutputPath>
    <DefineConstants>DEBUG;TRACE</DefineConstants>
    <ErrorReport>prompt</ErrorReport>
    <WarningLevel>4</WarningLevel>
  </PropertyGroup>
  <PropertyGroup Condition="" '$(Configuration)|$(Platform)' == 'Release|AnyCPU' "">
    <DebugType>pdbonly</DebugType>
    <Optimize>true</Optimize>
    <OutputPath>bin\</OutputPath>
    <DefineConstants>TRACE</DefineConstants>
    <ErrorReport>prompt</ErrorReport>
    <WarningLevel>4</WarningLevel>
  </PropertyGroup>
  <ItemGroup>
    <Reference Include=""Microsoft.CSharp"" />
    <Reference Include=""Newtonsoft.Json, Version=12.0.0.0, Culture=neutral, PublicKeyToken=30ad4fe6b2a6aeed, processorArchitecture=MSIL"">
        <HintPath>..\packages\Newtonsoft.Json.12.0.3\lib\net45\Newtonsoft.Json.dll</HintPath>
    </Reference>
    <Reference Include=""System.Web.DynamicData"" />
    <Reference Include=""System.Web.Entity"" />
    <Reference Include=""System.Web.ApplicationServices"" />
    <Reference Include=""System"" />
    <Reference Include=""System.Configuration"" />
    <Reference Include=""System.Core"" />
    <Reference Include=""System.Data"" />
    <Reference Include=""System.Drawing"" />
    <Reference Include=""System.EnterpriseServices"" />
    <Reference Include=""System.Runtime.Serialization"" />
    <Reference Include=""System.ServiceModel"" />
    <Reference Include=""System.ServiceModel.Web"" />
    <Reference Include=""System.Web"" />
    <Reference Include=""System.Web.Extensions"" />
    <Reference Include=""System.Web.Services"" />
    <Reference Include=""System.Xml"" />
    <Reference Include=""System.Xml.Linq"" />
  </ItemGroup>
  <ItemGroup>
    <Content Include=""HotelService.svc"" />
    <Content Include=""Web.config"" />
  </ItemGroup>
  <ItemGroup>
    <Compile Include=""HotelService.svc.cs"">
      <DependentUpon>HotelService.svc</DependentUpon>
    </Compile>
    <Compile Include=""IHotelService.cs"" />
    <Compile Include=""Properties\AssemblyInfo.cs"" />
  </ItemGroup>
  <ItemGroup>
    <Folder Include=""App_Data\"" />
  </ItemGroup>
  <ItemGroup>
    <None Include=""Web.Debug.config"">
      <DependentUpon>Web.config</DependentUpon>
    </None>
    <None Include=""Web.Release.config"">
      <DependentUpon>Web.config</DependentUpon>
    </None>
  </ItemGroup>
  <ItemGroup>
    <ProjectReference Include=""..\Hotel.Database\Hotel.Database.csproj"">
      <Project>{3AD86DE0-8AFC-4A9D-AC0B-6DC7D3CCB295}</Project>
      <Name>Hotel.Database</Name>
    </ProjectReference>
    <ProjectReference Include=""..\Hotel.Data\Hotel.Data.csproj"">
      <Project>{BD1E82C9-E6F6-4833-9164-56F3D6F57F20}</Project>
      <Name>Hotel.Data</Name>
    </ProjectReference>
  </ItemGroup>
  <PropertyGroup>
    <VisualStudioVersion Condition=""'$(VisualStudioVersion)' == ''"">10.0</VisualStudioVersion>
    <VSToolsPath Condition=""'$(VSToolsPath)' == ''"">$(MSBuildExtensionsPath32)\Microsoft\VisualStudio\v$(VisualStudioVersion)</VSToolsPath>
  </PropertyGroup>
  <Import Project=""$(MSBuildBinPath)\Microsoft.CSharp.targets"" />
  <Import Project=""$(VSToolsPath)\WebApplications\Microsoft.WebApplication.targets"" Condition=""'$(VSToolsPath)' != ''"" />
  <Import Project=""$(MSBuildExtensionsPath32)\Microsoft\VisualStudio\v10.0\WebApplications\Microsoft.WebApplication.targets"" Condition=""false"" />
  <ProjectExtensions>
    <VisualStudio>
      <FlavorProperties GUID=""{349c5851-65df-11da-9384-00065b846f21}"">
        <WebProjectProperties>
          <UseIIS>True</UseIIS>
          <AutoAssignPort>True</AutoAssignPort>
          <DevelopmentServerPort>1245</DevelopmentServerPort>
          <DevelopmentServerVPath>/</DevelopmentServerVPath>
          <IISUrl>http://localhost:1245/</IISUrl>
          <NTLMAuthentication>False</NTLMAuthentication>
          <UseCustomServer>False</UseCustomServer>
          <CustomServerUrl>
          </CustomServerUrl>
          <SaveServerSettingsInUserFile>False</SaveServerSettingsInUserFile>
        </WebProjectProperties>
      </FlavorProperties>
    </VisualStudio>
  </ProjectExtensions>
  <!-- To modify your build process, add your task inside one of the targets below and uncomment it. 
       Other similar extension points exist, see Microsoft.Common.targets.
  <Target Name=""BeforeBuild"">
  </Target>
  <Target Name=""AfterBuild"">
  </Target>
  -->
</Project>";

            public static class HotelServiceSvc
            {
                public const string FilePath = @"D:\Hotel\Hotel\HotelService.svc.cs";

                public const string Code = @"using System;
using System.Collections.Generic;
using System.Linq;
using Hotel.Data;
using Hotel.Database;

namespace Hotel
{
    public class HotelService : IHotelService
    {
        public IList<Room> GetAvailableRooms(DateTimeOffset checkInDate, DateTimeOffset checkOutDate)
        {
            var data = new RoomData();
            return data.GetAvailableRooms(checkInDate, checkOutDate).ToArray();
        }

        public Room GetRoom(int number)
        {
            var data = new RoomData();
            return data.GetRoom(number);
        }

        public Room[] GetRooms(int[] numbers)
        {
            var data = new RoomData();
            return data.GetRooms(numbers);
        }

        public IEnumerable<Room> AllRooms() => new RoomData().AllRooms();
    }
}
";
            }

            public static class IHotelService
            {
                public const string FilePath = @"D:\Hotel\Hotel\IHotelService.cs";

                public const string Code = @"using System;
using System.Collections.Generic;
using System.ServiceModel;
using Hotel.Data;

namespace Hotel
{
    [ServiceContract]
    public interface IHotelService
    {
        [OperationContract]
        IList<Room> GetAvailableRooms(DateTimeOffset checkInDate, DateTimeOffset checkOutDate);

        [OperationContract]
        Room GetRoom(int number);

        [OperationContract]
        Room[] GetRooms(int[] numbers);

        [OperationContract]
        IEnumerable<Room> AllRooms();
    }
}
";
            }
        }
    }
}