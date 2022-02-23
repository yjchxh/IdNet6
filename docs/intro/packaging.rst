Packaging and Builds
====================

IdentityServer consists of a number of nuget packages.

IdNet6 main repo
^^^^^^^^^^^^^^^
`github <https://github.com/identityserver/IdNet6>`_

Contains the core IdentityServer object model, services and middleware as well as the EntityFramework and ASP.NET Identity integration.

nugets:

* `IdNet6 <https://www.nuget.org/packages/IdNet6/>`_
* `IdNet6.EntityFramework <https://www.nuget.org/packages/IdNet6.EntityFramework>`_
* `IdNet6.AspNetIdentity <https://www.nuget.org/packages/IdNet6.AspNetIdentity>`_

Quickstart UI
^^^^^^^^^^^^^
`github <https://github.com/IdentityServer/IdNet6.Quickstart.UI>`_

Contains a simple starter UI including login, logout and consent pages.

Access token validation handler
^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
`nuget <https://www.nuget.org/packages/IdNet6.AccessTokenValidation>`_ | `github <https://github.com/IdentityServer/IdNet6.AccessTokenValidation>`_

ASP.NET Core authentication handler for validating tokens in APIs. The handler allows supporting both JWT and reference tokens in the same API.

Templates
^^^^^^^^^
`nuget <https://www.nuget.org/packages/IdNet6.Templates>`_ | `github <https://github.com/IdentityServer/IdNet6.Templates>`_

Contains templates for the dotnet CLI.

Dev builds
^^^^^^^^^^
In addition we publish CI builds to our package repository.
Add the following ``nuget.config`` to your project::

    <?xml version="1.0" encoding="utf-8"?>
        <configuration>
            <packageSources>
                <clear />
                <add key="IdentityServer CI" value="https://www.myget.org/F/identity/api/v3/index.json" />
            </packageSources>
        </configuration>
