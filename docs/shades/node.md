---
layout: docs
title: node
group: shades
---

@{/*

node
    Executes a node package manager command.

node_args=''
    Required. The arguments to pass to the node command line tool.

node_path='$(base_path)'
    The path in which to execute node.

base_path='$(CurrentDirectory)'
    The base path of the project.

node_wait='true'
    A value indicating whether or not to wait for exit.

node_quiet='$(Build.Log.Quiet)'
    A value indicating whether or not to avoid printing output.

*/}

use namespace = 'System'
use namespace = 'System.IO'

use import = 'Condo.Build'

default base_path       = '${ Directory.GetCurrentDirectory() }'

default node_args       = ''
default node_path       = '${ base_path }'
default node_wait       = '${ true }'
default node_quiet      = '${ Build.Log.Quiet }'

node-download once='node-download'

@{
    Build.Log.Header("node");

    var node_cmd        = Build.GetPath("node");

    if (string.IsNullOrEmpty(node_args))
    {
        throw new ArgumentException("node: cannot be executed without arguments.", "node_args");
    }

    Build.Log.Argument("cli", node_cmd.Path);
    Build.Log.Argument("arguments", node_args);
    Build.Log.Argument("path", node_path);
    Build.Log.Argument("wait", node_wait);
    Build.Log.Argument("quiet", node_quiet);
    Build.Log.Header();
}

exec exec_cmd='${ node_cmd.Path }' exec_args='${ node_args }' exec_path='${ node_path }' exec_wait='${ node_wait }' exec_quiet='${ node_quiet }' exec_redirect='${ false }'