---
layout: docs
title: grunt
group: shades
---

@{/*

grunt
    Executes a grunt task runner command.

grunt_args=''
    Required. The arguments to pass to the grunt command line tool.

grunt_options='' (Environment Variable: GRUNT_OPTIONS)
    Additional options to pass to the grunt command.

grunt_path='$(base_path)'
    The path in which to execute grunt.

base_path='$(CurrentDirectory)'
    The base path in which to execute grunt.

working_path='$(base_path)'
    The working path in which to execute grunt.

grunt_wait='true'
    A value indicating whether or not to wait for exit.

grunt_quiet='$(Build.Log.Quiet)'
    A value indicating whether or not to avoid printing output.

*/}

use namespace = 'System'
use namespace = 'System.IO'

use import = 'Condo.Build'

default base_path           = '${ Directory.GetCurrentDirectory() }'
default working_path        = '${ base_path }'

default grunt_args          = ''
default grunt_options       = '${ Build.Get("GRUNT_OPTIONS") }'
default grunt_path          = '${ working_path }'
default grunt_wait          = '${ true }'
default grunt_quiet         = '${ Build.Log.Quiet }'

grunt-download once='grunt-download'

@{
    Build.Log.Header("grunt");

    var grunt_cmd = Build.GetPath("grunt");

    if (!string.IsNullOrEmpty(grunt_args))
    {
        grunt_args = grunt_args.Trim();
    }

    if (!string.IsNullOrEmpty(grunt_options))
    {
        grunt_options = grunt_options.Trim();
    }

    Build.Log.Argument("cli", grunt_cmd.Path);
    Build.Log.Argument("arguments", grunt_args);
    Build.Log.Argument("options", grunt_options);
    Build.Log.Argument("path", grunt_path);
    Build.Log.Argument("wait", grunt_wait);
    Build.Log.Argument("quiet", grunt_quiet);
    Build.Log.Header();
}

exec exec_cmd='${ grunt_cmd.Path }' exec_args='${ grunt_args } ${ grunt_options }' exec_path='${ grunt_path }' exec_wait='${ grunt_wait }' exec_quiet='${ grunt_quiet }' exec_redirect='${ false }' if='grunt_cmd.Global'
node node_args='"${ grunt_cmd.Path }" ${ grunt_args } ${ grunt_options }' node_path='${ grunt_path }' node_wait='${ grunt_wait }' node_quiet='${ grunt_quiet }' if='!grunt_cmd.Global'