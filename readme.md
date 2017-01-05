# Sitecore.Support.141324
Solr BasicAuthentication patch

[![Total downloads](https://img.shields.io/github/downloads/SitecoreSupport/Sitecore.Support.141324/total.svg)](https://github.com/SitecoreSupport/Sitecore.Support.141324/releases)

## Main
This repo contains Sitecore Support patch #141324 that fixes BasicAuthentication issue for Solr indexing provider.

## Deployment
* Move `Sitecore.Support.141324.dll` assembly into the `\bin` folder.
* Move `Sitecore.Support.141324.config` file into `\App_Config\Include\zzz` folder.
* [Optional] If you don't have BasicAuthentication configured for Solr provider, see example in `\App_Config\Include\zzz\Sitecore.ContentSearch.Solr.BasicAuth.config.example` file.

## Content
The patch includes the following files:
* `\bin\Sitecore.Support.141324.dll`
* `\App_Config\Include\zzz\Sitecore.Support.141324.config`
* `\App_Config\Include\zzz\Sitecore.ContentSearch.Solr.BasicAuth.config.example`

## License  
This patch is licensed under the [Sitecore Corporation A/S License for GitHub](https://github.com/sitecoresupport/Sitecore.Support.141324/blob/master/LICENSE).  

## Download  
Downloads are available via [GitHub Releases](https://github.com/sitecoresupport/Sitecore.Support.141324/releases).  
