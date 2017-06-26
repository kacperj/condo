# CHANGE LOG

> All notable changes to this project will be documented in this file.

<a name="2.0.0"></a>
# [2.0.0](https://github.com/automotivemastermind/condo/compare/1.0.0...2.0.0) (2017-06-25)


### Bug Fixes

* **restore:** ignore failed sources on initial restore (#72) ([ff79b2f](https://github.com/automotivemastermind/condo/commits/ff79b2f)), closes [#72](https://github.com/automotivemastermind/condo/issues/72)
* **publish:** improve publish target detection (#69) ([42b1c9c](https://github.com/automotivemastermind/condo/commits/42b1c9c)), closes [#69](https://github.com/automotivemastermind/condo/issues/69) [#66](https://github.com/automotivemastermind/condo/issues/66)
* **detect-pr:** emit detection of pull requests (#68) ([e791845](https://github.com/automotivemastermind/condo/commits/e791845)), closes [#68](https://github.com/automotivemastermind/condo/issues/68)
* **nuget-push:** remove trailing slash on windows (#64) ([2692f5d](https://github.com/automotivemastermind/condo/commits/2692f5d)), closes [#64](https://github.com/automotivemastermind/condo/issues/64)
* ensure master branch always uses next version (#63) ([0777c6b](https://github.com/automotivemastermind/condo/commits/0777c6b)), closes [#63](https://github.com/automotivemastermind/condo/issues/63)
* **test:** add configuration to dotnet-test (#62) ([9c46c5f](https://github.com/automotivemastermind/condo/commits/9c46c5f)), closes [#62](https://github.com/automotivemastermind/condo/issues/62)
* **windows:** fix bootstrapping on windows (#60) ([b3ce495](https://github.com/automotivemastermind/condo/commits/b3ce495)), closes [#60](https://github.com/automotivemastermind/condo/issues/60) [#59](https://github.com/automotivemastermind/condo/issues/59)
* **install:** fix install on windows (#46) ([98993f1](https://github.com/automotivemastermind/condo/commits/98993f1)), closes [#46](https://github.com/automotivemastermind/condo/issues/46)
* **git:** checkout branch task was missing (#45) ([57462c7](https://github.com/automotivemastermind/condo/commits/57462c7)), closes [#45](https://github.com/automotivemastermind/condo/issues/45)
* **release:** checkout branch due to detached head (#41) ([05b4c26](https://github.com/automotivemastermind/condo/commits/05b4c26)), closes [#41](https://github.com/automotivemastermind/condo/issues/41)
* **release:** set author name/email (#40) ([df032a0](https://github.com/automotivemastermind/condo/commits/df032a0)), closes [#40](https://github.com/automotivemastermind/condo/issues/40)
* **project-json:** set prerelease tag when appropriate (#36) ([671843f](https://github.com/automotivemastermind/condo/commits/671843f)), closes [#36](https://github.com/automotivemastermind/condo/issues/36)
* **version:** fix recommended version for initial builds (#34) ([7820374](https://github.com/automotivemastermind/condo/commits/7820374)), closes [#34](https://github.com/automotivemastermind/condo/issues/34)
* **version:** issue with missing branch properties (#33) ([bdf2a74](https://github.com/automotivemastermind/condo/commits/bdf2a74)), closes [#33](https://github.com/automotivemastermind/condo/issues/33)
* **changelog:** resolve issue with tags (#32) ([774651c](https://github.com/automotivemastermind/condo/commits/774651c)), closes [#32](https://github.com/automotivemastermind/condo/issues/32)
* **dotnet:** pin the version of dotnet as dotnet-test is broken in preview3 (#28) ([1e64e33](https://github.com/automotivemastermind/condo/commits/1e64e33)), closes [#28](https://github.com/automotivemastermind/condo/issues/28)
* do not force push tags (#27) ([b53fb7f](https://github.com/automotivemastermind/condo/commits/b53fb7f)), closes [#27](https://github.com/automotivemastermind/condo/issues/27)
* **dotnet:** support projects where dotnet is not present (#24) ([bf55425](https://github.com/automotivemastermind/condo/commits/bf55425)), closes [#24](https://github.com/automotivemastermind/condo/issues/24)
* resolve issue where build quality could be incorrect ([2341c71](https://github.com/automotivemastermind/condo/commits/2341c71))
* bug in expand when downloading condo from src (#22) ([0a59505](https://github.com/automotivemastermind/condo/commits/0a59505)), closes [#22](https://github.com/automotivemastermind/condo/issues/22)


### Features

* **docs:** add support for github pages (#71) ([2863792](https://github.com/automotivemastermind/condo/commits/2863792)), closes [#71](https://github.com/automotivemastermind/condo/issues/71) [#82](https://github.com/automotivemastermind/condo/issues/82)
* **dotnet:** update dotnet to latest (#86) ([dce3e99](https://github.com/automotivemastermind/condo/commits/dce3e99)), closes [#86](https://github.com/automotivemastermind/condo/issues/86)
* **test:** add filtering by category (#70) ([3b75a8e](https://github.com/automotivemastermind/condo/commits/3b75a8e)), closes [#70](https://github.com/automotivemastermind/condo/issues/70)
* **docfx:** add support for docfx (#65) ([ae95308](https://github.com/automotivemastermind/condo/commits/ae95308)), closes [#65](https://github.com/automotivemastermind/condo/issues/65)
* **package:** use dotnet nuget in place of custom task (#48) ([0e46525](https://github.com/automotivemastermind/condo/commits/0e46525)), closes [#48](https://github.com/automotivemastermind/condo/issues/48) [#50](https://github.com/automotivemastermind/condo/issues/50) [dotnet/cli/#6123](https://github.com/automotivemastermind/condo/issues/6123)
* **msbuild:** add support for msbuild project system (#44) ([86c588a](https://github.com/automotivemastermind/condo/commits/86c588a)), closes [#44](https://github.com/automotivemastermind/condo/issues/44)
* **logging:** add msbuild logging everywhere (#38) ([3fa4633](https://github.com/automotivemastermind/condo/commits/3fa4633)), closes [#38](https://github.com/automotivemastermind/condo/issues/38)
* **project-json:** update semver in project.json (#35) ([d874638](https://github.com/automotivemastermind/condo/commits/d874638)), closes [#35](https://github.com/automotivemastermind/condo/issues/35)
* **log:** add support for conventional changelog (#31) ([8f27d5a](https://github.com/automotivemastermind/condo/commits/8f27d5a)), closes [#31](https://github.com/automotivemastermind/condo/issues/31)
* **dotnet:** add support for dotnet core 1.1 (#30) ([b74275c](https://github.com/automotivemastermind/condo/commits/b74275c)), closes [#30](https://github.com/automotivemastermind/condo/issues/30)
* **git-tag:** add support for version tagging in git repo (#26) ([2c0abce](https://github.com/automotivemastermind/condo/commits/2c0abce)), closes [#26](https://github.com/automotivemastermind/condo/issues/26)
* **nuget:** add support for nuget push of vsts protected feeds (#18) ([75a7d41](https://github.com/automotivemastermind/condo/commits/75a7d41)), closes [#18](https://github.com/automotivemastermind/condo/issues/18)
* **windows:** add support for building on windows (#17) ([961090d](https://github.com/automotivemastermind/condo/commits/961090d)), closes [#17](https://github.com/automotivemastermind/condo/issues/17)
* **dotnet-cli:** replace dnx support with dotnet-cli using msbuild (#16) ([c97c190](https://github.com/automotivemastermind/condo/commits/c97c190)), closes [#16](https://github.com/automotivemastermind/condo/issues/16) [#12](https://github.com/automotivemastermind/condo/issues/12) [#13](https://github.com/automotivemastermind/condo/issues/13)


### Performance Improvements

* **dotnet:** opt out of dotnet first run experience on build (#97) ([4ca1ca7](https://github.com/automotivemastermind/condo/commits/4ca1ca7)), closes [#97](https://github.com/automotivemastermind/condo/issues/97)
* **dotnet:** disable xml generation on nuget restore (#93) ([75e37b9](https://github.com/automotivemastermind/condo/commits/75e37b9)), closes [#93](https://github.com/automotivemastermind/condo/issues/93) [#93](https://github.com/automotivemastermind/condo/issues/93)
* **dotnet:** opt out of dotnet cli telemetry (#92) ([3822d5f](https://github.com/automotivemastermind/condo/commits/3822d5f)), closes [#92](https://github.com/automotivemastermind/condo/issues/92) [#92](https://github.com/automotivemastermind/condo/issues/92)
* **build:** improve build performance (#61) ([693dbb4](https://github.com/automotivemastermind/condo/commits/693dbb4)), closes [#61](https://github.com/automotivemastermind/condo/issues/61)


### BREAKING CHANGES

* **log:** 
Any existing bootstrap scripts *MUST* be updated due to some changes in how condo itself is retrieved and built. Replace the bootstrap scripts you rely on (`condo.ps1`, `condo.cmd`, and `condo.ps1`) from [here](https://github.com/pulsebridge/condo/tree/develop/template).
* **log:** 
Condo no longer uses the ```<SemanticVersion>``` tag found in `condo.build`. The version is now based on git tags.


<a name="1.0.0"></a>
# 1.0.0 (2016-07-08)


