﻿// <copyright file="ApplicationScenarios.cs" company="Okta, Inc">
// Copyright (c) 2014 - present Okta, Inc. All rights reserved.
// Licensed under the Apache 2.0 license. See the LICENSE file in the project root for full license information.
// </copyright>

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FluentAssertions;
using Xunit;

namespace Okta.Sdk.IntegrationTests
{
    [Collection(nameof(ApplicationScenarios))]
    public class ApplicationScenarios
    {
        [Fact]
        public async Task AddBookmarkApp()
        {
            var client = TestClient.Create();
            var guid = Guid.NewGuid();

            var createdApp = await client.Applications.CreateApplicationAsync(new CreateBookmarkApplicationOptions()
            {
                Label = $"dotnet-sdk: AddBookmarkApp {guid}",
                RequestIntegration = false,
                Url = "https://example.com/bookmark.htm",
            });

            try
            {
                var retrieved = await client.Applications.GetApplicationAsync<IBookmarkApplication>(createdApp.Id);
                retrieved.Name.Should().Be("bookmark");
                retrieved.Label.Should().Be($"dotnet-sdk: AddBookmarkApp {guid}");
                retrieved.SignOnMode.Should().Be(ApplicationSignOnMode.Bookmark);

                retrieved.Settings.App.RequestIntegration.Should().Be(false);
                retrieved.Settings.App.Url.Should().Be("https://example.com/bookmark.htm");
            }
            finally
            {
                await client.Applications.DeactivateApplicationAsync(createdApp.Id);
                await client.Applications.DeleteApplicationAsync(createdApp.Id);
            }
        }

        [Fact]
        public async Task AddBasicAuthenticationApp()
        {
            var client = TestClient.Create();
            var guid = Guid.NewGuid();

            var createdApp = await client.Applications.CreateApplicationAsync(new CreateBasicAuthApplicationOptions()
            {
                Label = $"dotnet-sdk: AddBasicAuthenticationApp {guid}",
                Url = "https://example.com/login.html",
                AuthUrl = "https://example.com/auth.html",
            });

            try
            {
                var retrieved = await client.Applications.GetApplicationAsync<IBasicAuthApplication>(createdApp.Id);
                retrieved.Name.Should().Be("template_basic_auth");
                retrieved.Label.Should().Be($"dotnet-sdk: AddBasicAuthenticationApp {guid}");
                retrieved.SignOnMode.Should().Be(ApplicationSignOnMode.BasicAuth);

                retrieved.Settings.App.AuthUrl.Should().Be("https://example.com/auth.html");
                retrieved.Settings.App.Url.Should().Be("https://example.com/login.html");
            }
            finally
            {
                await client.Applications.DeactivateApplicationAsync(createdApp.Id);
                await client.Applications.DeleteApplicationAsync(createdApp.Id);
            }
        }

        [Fact]
        public async Task AddSwaApp()
        {
            var client = TestClient.Create();
            var guid = Guid.NewGuid();

            var createdApp = await client.Applications.CreateApplicationAsync(new CreateSwaApplicationOptions
            {
                Label = $"dotnet-sdk: AddSwaApp {guid}",
                ButtonField = "btn-login",
                PasswordField = "txtbox-password",
                UsernameField = "txtbox-username",
                Url = "https://example.com/login.html",
                LoginUrlRegex = "^https://example.com/login.html",
            });

            try
            {
                var retrieved = await client.Applications.GetApplicationAsync<ISwaApplication>(createdApp.Id);
                retrieved.Name.Should().Be("template_swa");
                retrieved.Label.Should().Be($"dotnet-sdk: AddSwaApp {guid}");
                retrieved.SignOnMode.Should().Be(ApplicationSignOnMode.BrowserPlugin);
                retrieved.Settings.App.ButtonField.Should().Be("btn-login");
                retrieved.Settings.App.PasswordField.Should().Be("txtbox-password");
                retrieved.Settings.App.UsernameField.Should().Be("txtbox-username");
                retrieved.Settings.App.Url.Should().Be("https://example.com/login.html");
                retrieved.Settings.App.LoginUrlRegex.Should().Be("^https://example.com/login.html");
            }
            finally
            {
                await client.Applications.DeactivateApplicationAsync(createdApp.Id);
                await client.Applications.DeleteApplicationAsync(createdApp.Id);
            }
        }

        [Fact]
        public async Task AddSwaThreeFieldApp()
        {
            var client = TestClient.Create();
            var guid = Guid.NewGuid();

            var createdApp = await client.Applications.CreateApplicationAsync(new CreateSwaThreeFieldApplicationOptions
            {
                Label = $"dotnet-sdk: AddSwaThreeFieldApp {guid}",
                ButtonSelector = "#btn-login",
                PasswordSelector = "#txtbox-password",
                UserNameSelector = "#txtbox-username",
                TargetUrl = "https://example.com/login.html",
                ExtraFieldSelector = ".login",
                ExtraFieldValue = "SOMEVALUE",
                LoginUrlRegex = "^https://example.com/login.html",
            });

            try
            {
                var retrieved = await client.Applications.GetApplicationAsync<ISwaThreeFieldApplication>(createdApp.Id);
                retrieved.Name.Should().Be("template_swa3field");
                retrieved.Label.Should().Be($"dotnet-sdk: AddSwaThreeFieldApp {guid}");
                retrieved.SignOnMode.Should().Be(ApplicationSignOnMode.BrowserPlugin);
                retrieved.Settings.App.ButtonSelector.Should().Be("#btn-login");
                retrieved.Settings.App.PasswordSelector.Should().Be("#txtbox-password");
                retrieved.Settings.App.UserNameSelector.Should().Be("#txtbox-username");
                retrieved.Settings.App.TargetUrl.Should().Be("https://example.com/login.html");
                retrieved.Settings.App.LoginUrlRegex.Should().Be("^https://example.com/login.html");
                retrieved.Settings.App.ExtraFieldSelector.Should().Be(".login");
                retrieved.Settings.App.ExtraFieldValue.Should().Be("SOMEVALUE");
            }
            finally
            {
                await client.Applications.DeactivateApplicationAsync(createdApp.Id);
                await client.Applications.DeleteApplicationAsync(createdApp.Id);
            }
        }

        [Fact]
        public async Task AddSwaNoPluginApp()
        {
            var client = TestClient.Create();
            var guid = Guid.NewGuid();

            var createdApp = await client.Applications.CreateApplicationAsync(new CreateSwaNoPluginApplicationOptions
            {
                Label = $"dotnet-sdk: AddSwaNoPluginApp {guid}",
                Url = "https://example.com/login.html",
                PasswordField = "#txtbox-password",
                UsernameField = "#txtbox-username",
                OptionalField1 = "param1",
                OptionalField1Value = "somevalue",
                OptionalField2 = "param2",
                OptionalField2Value = "yetanothervalue",
                OptionalField3 = "param3",
                OptionalField3Value = "finalvalue",
            });

            try
            {
                var retrieved = await client.Applications.GetApplicationAsync<ISecurePasswordStoreApplication>(createdApp.Id);
                retrieved.Name.Should().Be("template_sps");
                retrieved.Label.Should().Be($"dotnet-sdk: AddSwaNoPluginApp {guid}");
                retrieved.SignOnMode.Should().Be(ApplicationSignOnMode.SecurePasswordStore);
                retrieved.Settings.App.PasswordField.Should().Be("#txtbox-password");
                retrieved.Settings.App.UsernameField.Should().Be("#txtbox-username");
                retrieved.Settings.App.Url.Should().Be("https://example.com/login.html");
                retrieved.Settings.App.OptionalField1.Should().Be("param1");
                retrieved.Settings.App.OptionalField1Value.Should().Be("somevalue");
                retrieved.Settings.App.OptionalField2.Should().Be("param2");
                retrieved.Settings.App.OptionalField2Value.Should().Be("yetanothervalue");
                retrieved.Settings.App.OptionalField3.Should().Be("param3");
                retrieved.Settings.App.OptionalField3Value.Should().Be("finalvalue");
            }
            finally
            {
                await client.Applications.DeactivateApplicationAsync(createdApp.Id);
                await client.Applications.DeleteApplicationAsync(createdApp.Id);
            }
        }

        [Fact]
        public async Task AddSwaCustomApp()
        {
            var client = TestClient.Create();
            var guid = Guid.NewGuid();

            var createdApp = await client.Applications.CreateApplicationAsync(new CreateSwaCustomApplicationOptions
            {
                Label = $"dotnet-sdk: AddSwaCustomApp {guid}",
                Features = new List<string>(),
                AutoSubmitToolbar = false,
                HideIOs = false,
                HideWeb = false,
                RedirectUrl = "http://swasecondaryredirecturl.okta.com",
                LoginUrl = "http://swaprimaryloginurl.okta.com",
            });

            try
            {
                var retrieved = await client.Applications.GetApplicationAsync<IAutoLoginApplication>(createdApp.Id);
                retrieved.Label.Should().Be($"dotnet-sdk: AddSwaCustomApp {guid}");
                retrieved.SignOnMode.Should().Be(ApplicationSignOnMode.AutoLogin);
                retrieved.Features.Should().BeEmpty();
                retrieved.Visibility.AutoSubmitToolbar.Should().BeFalse();
                retrieved.Visibility.Hide.IOs.Should().BeFalse();
                retrieved.Visibility.Hide.Web.Should().BeFalse();
                retrieved.Settings.SignOn.RedirectUrl.Should().Be("http://swasecondaryredirecturl.okta.com");
                retrieved.Settings.SignOn.LoginUrl.Should().Be("http://swaprimaryloginurl.okta.com");
            }
            finally
            {
                await client.Applications.DeactivateApplicationAsync(createdApp.Id);
                await client.Applications.DeleteApplicationAsync(createdApp.Id);
            }
        }

        [Fact]
        public async Task AddSamlCustomApp()
        {
            var client = TestClient.Create();
            var guid = Guid.NewGuid();

            var createdApp = await client.Applications.CreateApplicationAsync(new CreateSamlApplicationOptions
            {
                Label = $"dotnet-sdk: AddSamlCustomApp {guid}",
                Features = new List<string>(),
                AutoSubmitToolbar = false,
                HideIOs = false,
                HideWeb = false,
                DefaultRelayState = string.Empty,
                SsoAcsUrl = "http://testorgone.okta",
                IdpIssuer = "http://www.okta.com/${org.externalKey}",
                Audience = "asdqwe123",
                Recipient = "http://testorgone.okta",
                Destination = "http://testorgone.okta",
                SubjectNameIdTemplate = "${user.userName}",
                SubjectNameIdFormat = "urn:oasis:names:tc:SAML:1.1:nameid-format:unspecified",
                ResponseSigned = true,
                AssertionSigned = true,
                SignatureAlgorithm = "RSA_SHA256",
                DigestAlgorithm = "SHA256",
                HonorForceAuthentication = true,
                AuthenticationContextClassName = "urn:oasis:names:tc:SAML:2.0:ac:classes:PasswordProtectedTransport",
                SpIssuer = null,
                RequestCompressed = false,
                AttributeStatements = new List<ISamlAttributeStatement>
                {
                    new SamlAttributeStatement()
                        {
                        Name = "Attribute",
                        Type = "EXPRESSION",
                        Namespace = "urn:oasis:names:tc:SAML:2.0:attrname-format:unspecified",
                        Values = new List<string>() { "Value" },
                    },
                },
            });

            try
            {
                var retrieved = await client.Applications.GetApplicationAsync<ISamlApplication>(createdApp.Id);
                retrieved.Label.Should().Be($"dotnet-sdk: AddSamlCustomApp {guid}");
                retrieved.SignOnMode.Should().Be(ApplicationSignOnMode.Saml2);
                retrieved.Features.Should().BeEmpty();
                retrieved.Visibility.AutoSubmitToolbar.Should().BeFalse();
                retrieved.Visibility.Hide.IOs.Should().BeFalse();
                retrieved.Visibility.Hide.Web.Should().BeFalse();
                retrieved.Settings.SignOn.DefaultRelayState.Should().BeNullOrEmpty();
                retrieved.Settings.SignOn.SsoAcsUrl.Should().Be("http://testorgone.okta");
                retrieved.Settings.SignOn.IdpIssuer.Should().Be("http://www.okta.com/${org.externalKey}");
                retrieved.Settings.SignOn.Audience.Should().Be("asdqwe123");
                retrieved.Settings.SignOn.Recipient.Should().Be("http://testorgone.okta");
                retrieved.Settings.SignOn.Destination.Should().Be("http://testorgone.okta");
                retrieved.Settings.SignOn.SubjectNameIdTemplate.Should().Be("${user.userName}");
                retrieved.Settings.SignOn.SubjectNameIdFormat.Should().Be("urn:oasis:names:tc:SAML:1.1:nameid-format:unspecified");
                retrieved.Settings.SignOn.ResponseSigned.Should().BeTrue();
                retrieved.Settings.SignOn.AssertionSigned.Should().BeTrue();
                retrieved.Settings.SignOn.SignatureAlgorithm.Should().Be("RSA_SHA256");
                retrieved.Settings.SignOn.DigestAlgorithm.Should().Be("SHA256");
                retrieved.Settings.SignOn.HonorForceAuthentication.Should().BeTrue();
                retrieved.Settings.SignOn.AuthenticationContextClassName.Should().Be("urn:oasis:names:tc:SAML:2.0:ac:classes:PasswordProtectedTransport");
                retrieved.Settings.SignOn.SpIssuer.Should().BeNull();
                retrieved.Settings.SignOn.RequestCompressed.Should().BeFalse();
                retrieved.Settings.SignOn.AttributeStatements.Should().HaveCount(1);
                retrieved.Settings.SignOn.AttributeStatements.First().Type.Should().Be("EXPRESSION");
                retrieved.Settings.SignOn.AttributeStatements.First().Name.Should().Be("Attribute");
                retrieved.Settings.SignOn.AttributeStatements.First().Namespace.Should().Be("urn:oasis:names:tc:SAML:2.0:attrname-format:unspecified");
                retrieved.Settings.SignOn.AttributeStatements.First().Values.Should().HaveCount(1);
                retrieved.Settings.SignOn.AttributeStatements.First().Values.First().Should().Be("Value");
            }
            finally
            {
                await client.Applications.DeactivateApplicationAsync(createdApp.Id);
                await client.Applications.DeleteApplicationAsync(createdApp.Id);
            }
        }

        [Fact]
        [Trait("Category", "NoBacon")] // Tests that don't run on internal CI pipeline
        public async Task AddWsFederationApp()
        {
            var client = TestClient.Create();
            var guid = Guid.NewGuid();

            var createdApp = await client.Applications.CreateApplicationAsync(new CreateWsFederationApplicationOptions
            {
                Label = $"dotnet-sdk: AddWsFederationApp {guid}",
                AudienceRestriction = "urn:example:app",
                GroupName = null,
                GroupValueFormat = "windowsDomainQualifiedName",
                Realm = "urn:example:app",
                WReplyUrl = "https://example.com/",
                AttributeStatements = null,
                NameIdFormat = "urn:oasis:names:tc:SAML:1.1:nameid-format:unspecified",
                AuthenticationContextClassName = "urn:oasis:names:tc:SAML:2.0:ac:classes:PasswordProtectedTransport",
                SiteUrl = "https://example.com",
                WReplyOverride = false,
                GroupFilter = null,
                UsernameAttribute = "username",
            });

            try
            {
                var retrieved = await client.Applications.GetApplicationAsync<IWsFederationApplication>(createdApp.Id);
                retrieved.Name.Should().Be("template_wsfed");
                retrieved.Label.Should().Be($"dotnet-sdk: AddWsFederationApp {guid}");
                retrieved.SignOnMode.Should().Be(ApplicationSignOnMode.WsFederation);
                retrieved.Settings.App.AudienceRestriction.Should().Be("urn:example:app");
                retrieved.Settings.App.GroupName.Should().NotBeNullOrEmpty();
                retrieved.Settings.App.GroupValueFormat.Should().Be("windowsDomainQualifiedName");
                retrieved.Settings.App.Realm.Should().Be("urn:example:app");
                retrieved.Settings.App.WReplyUrl.Should().Be("https://example.com/");
                retrieved.Settings.App.AttributeStatements.Should().BeNull();
                retrieved.Settings.App.NameIdFormat.Should().Be("urn:oasis:names:tc:SAML:1.1:nameid-format:unspecified");
                retrieved.Settings.App.AuthenticationContextClassName.Should().Be("urn:oasis:names:tc:SAML:2.0:ac:classes:PasswordProtectedTransport");
                retrieved.Settings.App.SiteUrl.Should().Be("https://example.com");
                retrieved.Settings.App.WReplyOverride.Should().BeFalse();
                retrieved.Settings.App.GroupFilter.Should().BeNull();
                retrieved.Settings.App.UsernameAttribute.Should().Be("username");
            }
            finally
            {
                await client.Applications.DeactivateApplicationAsync(createdApp.Id);
                await client.Applications.DeleteApplicationAsync(createdApp.Id);
            }
        }

        [Fact]
        public async Task AddOpenIdConnectApp()
        {
            var client = TestClient.Create();
            var guid = Guid.NewGuid();
            var testClientId = $"{nameof(AddOpenIdConnectApp)}_TestClientId";

            var jwk = new JsonWebKey()
            {
                Kty = "RSA",
                Kid = "SIGNING_KEY",
                E = "AQAB",
                N = "MIIBIzANBgkqhkiG9w0BAQEFAAOCARAAMIIBCwKCAQIAnFo/4e91na8x/BsPkNS5QkwankewxJ1uZU6p827W/gkRcNHtNi/cE644W5OVdB4UaXV6koT+TsC1prhUEhRR3g5ggE0B/lwYqBaLq/Ejy19Crc4XYU3Aah67Y6HiHWcHGZ+BbpebtTixJv/UYW/Gw+k8M+zj4O001mOeBPpwlEiZZLIo33m/Xkfn28jaCFqTQBJHr67IQh4zEUFs4e5D5D6UE8ee93yeSUJyhbifeIgYh3tS/+ZW4Uo1KLIc0rcLRrnEMsS3aOQbrv/SEKij+Syx4KXI0Gi2xMdXctnFOVT6NM6/EkLxFp2POEdv9SNBtTvXcxIGRwK51W4Jdgh/xZcCAwEAAQ==",
            };

            var keys = new List<IJsonWebKey>() { jwk };

            var createdApp = await client.Applications.CreateApplicationAsync(new CreateOpenIdConnectApplication
            {
                Label = $"dotnet-sdk: AddOpenIdConnectApp {guid}",
                ClientId = testClientId,
                TokenEndpointAuthMethod = OAuthEndpointAuthenticationMethod.ClientSecretPost,
                AutoKeyRotation = true,
                ClientUri = "https://example.com/client",
                LogoUri = "https://example.com/assets/images/logo-new.png",
                ResponseTypes = new List<OAuthResponseType>
                {
                    OAuthResponseType.Token,
                    OAuthResponseType.IdToken,
                    OAuthResponseType.Code,
                },
                RedirectUris = new List<string>
                {
                        "https://example.com/oauth2/callback",
                        "myapp://callback",
                },
                PostLogoutRedirectUris = new List<string>
                {
                    "https://example.com/postlogout",
                    "myapp://postlogoutcallback",
                },
                GrantTypes = new List<OAuthGrantType>
                {
                    OAuthGrantType.Implicit,
                    OAuthGrantType.AuthorizationCode,
                },
                Keys = keys,
                ApplicationType = OpenIdConnectApplicationType.Native,
                TermsOfServiceUri = "https://example.com/client/tos",
                PolicyUri = "https://example.com/client/policy",
            });

            try
            {
                var retrieved = await client.Applications.GetApplicationAsync<IOpenIdConnectApplication>(createdApp.Id);
                retrieved.Name.Should().Be("oidc_client");
                retrieved.Label.Should().Be($"dotnet-sdk: AddOpenIdConnectApp {guid}");
                retrieved.SignOnMode.Should().Be(ApplicationSignOnMode.OpenIdConnect);
                retrieved.Credentials.OauthClient.ClientId.Should().Be(testClientId);
                retrieved.Credentials.OauthClient.AutoKeyRotation.Should().BeTrue();
                retrieved.Credentials.OauthClient.TokenEndpointAuthMethod.Should().Be(OAuthEndpointAuthenticationMethod.ClientSecretPost);

                retrieved.Settings.OAuthClient.ClientUri.Should().Be("https://example.com/client");
                retrieved.Settings.OAuthClient.LogoUri.Should().Be("https://example.com/assets/images/logo-new.png");
                retrieved.Settings.OAuthClient.RedirectUris.Should().HaveCount(2);
                retrieved.Settings.OAuthClient.RedirectUris.First().Should().Be("https://example.com/oauth2/callback");
                retrieved.Settings.OAuthClient.RedirectUris.Last().Should().Be("myapp://callback");
                retrieved.Settings.OAuthClient.PostLogoutRedirectUris.Should().HaveCount(2);
                retrieved.Settings.OAuthClient.PostLogoutRedirectUris.First().Should().Be("https://example.com/postlogout");
                retrieved.Settings.OAuthClient.PostLogoutRedirectUris.Last().Should().Be("myapp://postlogoutcallback");

                retrieved.Settings.OAuthClient.ResponseTypes.Should().HaveCount(3);
                retrieved.Settings.OAuthClient.ResponseTypes.First().Should().Be(OAuthResponseType.Token);
                retrieved.Settings.OAuthClient.ResponseTypes.Should().Contain(OAuthResponseType.IdToken);
                retrieved.Settings.OAuthClient.ResponseTypes.Should().Contain(OAuthResponseType.Code);

                retrieved.Settings.OAuthClient.GrantTypes.Should().HaveCount(2);
                retrieved.Settings.OAuthClient.GrantTypes.First().Should().Be(OAuthGrantType.Implicit);
                retrieved.Settings.OAuthClient.GrantTypes.Last().Should().Be(OAuthGrantType.AuthorizationCode);
                retrieved.Settings.OAuthClient.ApplicationType.Should().Be(OpenIdConnectApplicationType.Native);

                retrieved.Settings.OAuthClient.Jwks.Keys.Should().NotBeNullOrEmpty();
                retrieved.Settings.OAuthClient.Jwks.Keys.FirstOrDefault().Alg.Should().Be(jwk.Alg);
                retrieved.Settings.OAuthClient.Jwks.Keys.FirstOrDefault().Kty.Should().Be(jwk.Kty);
                retrieved.Settings.OAuthClient.Jwks.Keys.FirstOrDefault().E.Should().Be(jwk.E);
                retrieved.Settings.OAuthClient.Jwks.Keys.FirstOrDefault().N.Should().Be(jwk.N);
            }
            finally
            {
                await client.Applications.DeactivateApplicationAsync(createdApp.Id);
                await client.Applications.DeleteApplicationAsync(createdApp.Id);
            }
        }

        [Fact]
        public async Task GetApplication()
        {
            var client = TestClient.Create();

            var createdApp = await client.Applications.CreateApplicationAsync(new CreateBasicAuthApplicationOptions()
            {
                Label = $"dotnet-sdk: GetApplication {Guid.NewGuid()}",
                Url = "https://example.com/login.html",
                AuthUrl = "https://example.com/auth.html",
            });

            try
            {
                var retrievedById = await client.Applications.GetApplicationAsync(createdApp.Id);
                retrievedById.Id.Should().Be(createdApp.Id);
            }
            finally
            {
                await client.Applications.DeactivateApplicationAsync(createdApp.Id);
                await client.Applications.DeleteApplicationAsync(createdApp.Id);
            }
        }

        [Fact]
        public async Task ListApplications()
        {
            var client = TestClient.Create();

            var createdApp = await client.Applications.CreateApplicationAsync(new CreateBasicAuthApplicationOptions()
            {
                Label = $"dotnet-sdk: ListApplications {Guid.NewGuid()}",
                Url = "https://example.com/login.html",
                AuthUrl = "https://example.com/auth.html",
            });

            try
            {
                var appList = await client.Applications.ToArrayAsync();
                appList.SingleOrDefault(a => a.Id == createdApp.Id).Should().NotBeNull();
            }
            finally
            {
                await client.Applications.DeactivateApplicationAsync(createdApp.Id);
                await client.Applications.DeleteApplicationAsync(createdApp.Id);
            }
        }

        [Fact]
        public async Task ListApplicationsOfType()
        {
            var client = TestClient.Create();
            var guid = Guid.NewGuid();

            var createdBasicApp = await client.Applications.CreateApplicationAsync(new CreateBasicAuthApplicationOptions()
            {
                Label = $"dotnet-sdk: ListApplicationsOfType 1 {Guid.NewGuid()}",
                Url = "https://example.com/login.html",
                AuthUrl = "https://example.com/auth.html",
            });

            var createdBookmarkApp = await client.Applications.CreateApplicationAsync(new CreateBookmarkApplicationOptions()
            {
                Label = $"dotnet-sdk: ListApplicationsOfType 2 {Guid.NewGuid()}",
                RequestIntegration = false,
                Url = "https://example.com/bookmark.htm",
            });

            try
            {
                var appList = await client.Applications.ListApplications().OfType<IBookmarkApplication>().ToArrayAsync();
                appList.Should().HaveCount(1);

                var bookmarkApp = await client.Applications.ListApplications().OfType<IBookmarkApplication>().FirstOrDefaultAsync();
                bookmarkApp.Should().NotBeNull();
                bookmarkApp.SignOnMode.Should().Be(ApplicationSignOnMode.Bookmark);
            }
            finally
            {
                await client.Applications.DeactivateApplicationAsync(createdBookmarkApp.Id);
                await client.Applications.DeleteApplicationAsync(createdBookmarkApp.Id);
                await client.Applications.DeactivateApplicationAsync(createdBasicApp.Id);
                await client.Applications.DeleteApplicationAsync(createdBasicApp.Id);
            }
        }

        [Fact]
        public async Task UpdateSWAApplicationAdminSetUsernameAndPassword()
        {
            var client = TestClient.Create();

            var createdApp = await client.Applications.CreateApplicationAsync(new CreateSwaApplicationOptions
            {
                Label = $"dotnet-sdk: UpdateSWAApplicationAdminSetUsernameAndPassword {Guid.NewGuid()}",
                ButtonField = "btn-login",
                PasswordField = "txtbox-password",
                UsernameField = "txtbox-username",
                Url = "https://example.com/login.html",
                LoginUrlRegex = "^https://example.com/login.html",
            });

            try
            {
                var retrieved = await client.Applications.GetApplicationAsync<ISwaApplication>(createdApp.Id);

                // Checking defaults
                retrieved.Credentials.Scheme.Should().Be(ApplicationCredentialsScheme.EditUsernameAndPassword);
                retrieved.Credentials.UserNameTemplate.Template.Should().Be("${source.login}");
                retrieved.Credentials.UserNameTemplate.Type.Should().Be("BUILT_IN");

                var schemeAppCredentials = new SchemeApplicationCredentials()
                {
                    Scheme = ApplicationCredentialsScheme.AdminSetsCredentials,
                    UserNameTemplate = new ApplicationCredentialsUsernameTemplate()
                    {
                        Template = "${source.login}",
                        Type = "BUILT_IN",
                    },
                };

                retrieved.Credentials.Scheme = ApplicationCredentialsScheme.AdminSetsCredentials;
                retrieved.Credentials.UserNameTemplate.Template = "${source.login}";
                retrieved.Credentials.UserNameTemplate.Type = "BUILT_IN";

                retrieved = await client.Applications.UpdateApplicationAsync<ISwaApplication>(retrieved, retrieved.Id);

                retrieved.Credentials.Scheme.Should().Be(ApplicationCredentialsScheme.AdminSetsCredentials);
                retrieved.Credentials.UserNameTemplate.Template.Should().Be("${source.login}");
                retrieved.Credentials.UserNameTemplate.Type.Should().Be("BUILT_IN");
            }
            finally
            {
                await client.Applications.DeactivateApplicationAsync(createdApp.Id);
                await client.Applications.DeleteApplicationAsync(createdApp.Id);
            }
        }

        [Fact]
        public async Task UpdateSWAApplicationSetUserEditablePassword()
        {
            var client = TestClient.Create();

            var createdApp = await client.Applications.CreateApplicationAsync(new CreateSwaApplicationOptions
            {
                Label = $"dotnet-sdk: UpdateSWAApplicationSetUserEditablePassword {Guid.NewGuid()}",
                ButtonField = "btn-login",
                PasswordField = "txtbox-password",
                UsernameField = "txtbox-username",
                Url = "https://example.com/login.html",
                LoginUrlRegex = "^https://example.com/login.html",
            });

            try
            {
                var retrieved = await client.Applications.GetApplicationAsync<ISwaApplication>(createdApp.Id);

                // Checking defaults
                retrieved.Credentials.Scheme.Should().Be(ApplicationCredentialsScheme.EditUsernameAndPassword);
                retrieved.Credentials.UserNameTemplate.Template.Should().Be("${source.login}");
                retrieved.Credentials.UserNameTemplate.Type.Should().Be("BUILT_IN");

                retrieved.Credentials.Scheme = ApplicationCredentialsScheme.EditPasswordOnly;
                retrieved.Credentials.UserNameTemplate.Template = "${source.login}";
                retrieved.Credentials.UserNameTemplate.Type = "BUILT_IN";

                retrieved = await client.Applications.UpdateApplicationAsync<ISwaApplication>(retrieved, retrieved.Id);

                retrieved.Credentials.Scheme.Should().Be(ApplicationCredentialsScheme.EditPasswordOnly);
                retrieved.Credentials.UserNameTemplate.Template.Should().Be("${source.login}");
                retrieved.Credentials.UserNameTemplate.Type.Should().Be("BUILT_IN");
            }
            finally
            {
                await client.Applications.DeactivateApplicationAsync(createdApp.Id);
                await client.Applications.DeleteApplicationAsync(createdApp.Id);
            }
        }

        [Fact]
        public async Task UpdateSWAApplicationSetSharedCredentials()
        {
            var client = TestClient.Create();

            var createdApp = await client.Applications.CreateApplicationAsync(new CreateSwaApplicationOptions
            {
                Label = $"dotnet-sdk: UpdateSWAApplicationSetSharedCredentials {Guid.NewGuid()}",
                ButtonField = "btn-login",
                PasswordField = "txtbox-password",
                UsernameField = "txtbox-username",
                Url = "https://example.com/login.html",
                LoginUrlRegex = "^https://example.com/login.html",
            });

            try
            {
                var retrieved = await client.Applications.GetApplicationAsync<ISwaApplication>(createdApp.Id);

                // Checking defaults
                retrieved.Credentials.Scheme.Should().Be(ApplicationCredentialsScheme.EditUsernameAndPassword);
                retrieved.Credentials.UserNameTemplate.Template.Should().Be("${source.login}");
                retrieved.Credentials.UserNameTemplate.Type.Should().Be("BUILT_IN");

                retrieved.Credentials.Scheme = ApplicationCredentialsScheme.SharedUsernameAndPassword;
                retrieved.Credentials.UserNameTemplate.Template = "${source.login}";
                retrieved.Credentials.UserNameTemplate.Type = "BUILT_IN";
                retrieved.Credentials.UserName = "sharedusername";
                retrieved.Credentials.Password = new PasswordCredential() { Value = "sharedpassword" };

                retrieved = await client.Applications.UpdateApplicationAsync<ISwaApplication>(retrieved, retrieved.Id);

                retrieved.Credentials = retrieved.GetProperty<SchemeApplicationCredentials>("credentials");
                retrieved.Credentials.Scheme.Should().Be(ApplicationCredentialsScheme.SharedUsernameAndPassword);
                retrieved.Credentials.UserNameTemplate.Template.Should().Be("${source.login}");
                retrieved.Credentials.UserNameTemplate.Type.Should().Be("BUILT_IN");
                retrieved.Credentials.UserName.Should().Be("sharedusername");
                retrieved.Credentials.Password.Value.Should().BeNullOrEmpty();
            }
            finally
            {
                await client.Applications.DeactivateApplicationAsync(createdApp.Id);
                await client.Applications.DeleteApplicationAsync(createdApp.Id);
            }
        }

        [Fact]
        public async Task NotDeleteActiveApplication()
        {
            var client = TestClient.Create();

            var createdApp = await client.Applications.CreateApplicationAsync(new CreateBasicAuthApplicationOptions()
            {
                Label = $"dotnet-sdk: NotDeleteActiveApplication {Guid.NewGuid()}",
                Url = "https://example.com/login.html",
                AuthUrl = "https://example.com/auth.html",
            });

            try
            {
                // Deleting by ID should result in 403 Forbidden
                await Assert.ThrowsAsync<OktaApiException>(() => client.Applications.DeleteApplicationAsync(createdApp.Id));
            }
            finally
            {
                await client.Applications.DeactivateApplicationAsync(createdApp.Id);
                await client.Applications.DeleteApplicationAsync(createdApp.Id);
            }
        }

        [Fact]
        public async Task DeleteDeactivatedApplication()
        {
            var client = TestClient.Create();

            var createdApp = await client.Applications.CreateApplicationAsync(new CreateBasicAuthApplicationOptions()
            {
                Label = $"dotnet-sdk: DeleteDeactivatedApplication {Guid.NewGuid()}",
                Url = "https://example.com/login.html",
                AuthUrl = "https://example.com/auth.html",
            });

            var appId = createdApp.Id;

            await client.Applications.DeactivateApplicationAsync(createdApp.Id);
            await client.Applications.DeleteApplicationAsync(createdApp.Id);

            // Getting by ID should result in 404 Not found
            await Assert.ThrowsAsync<OktaApiException>(() => client.Applications.GetApplicationAsync(appId));
        }

        [Fact]
        public async Task ActivateApplication()
        {
            var client = TestClient.Create();

            var createdApp = await client.Applications.CreateApplicationAsync(
                new CreateBasicAuthApplicationOptions()
                {
                    Label = $"dotnet-sdk: ActivateApplication {Guid.NewGuid()}",
                    Url = "https://example.com/login.html",
                    AuthUrl = "https://example.com/auth.html",
                    Activate = false,
                });

            try
            {
                var retrievedApp = await client.Applications.GetApplicationAsync(createdApp.Id);
                retrievedApp.Status.Should().Be("INACTIVE");

                await client.Applications.ActivateApplicationAsync(createdApp.Id);
                retrievedApp = await client.Applications.GetApplicationAsync(createdApp.Id);
                retrievedApp.Status.Should().Be("ACTIVE");
            }
            finally
            {
                await client.Applications.DeactivateApplicationAsync(createdApp.Id);
                await client.Applications.DeleteApplicationAsync(createdApp.Id);
            }
        }

        [Fact]
        public async Task CreateActiveApplication()
        {
            var client = TestClient.Create();

            var createdApp = await client.Applications.CreateApplicationAsync(
                new CreateBasicAuthApplicationOptions()
                {
                    Label = $"dotnet-sdk: CreateActiveApplication {Guid.NewGuid()}",
                    Url = "https://example.com/login.html",
                    AuthUrl = "https://example.com/auth.html",
                });

            try
            {
                var retrievedApp = await client.Applications.GetApplicationAsync(createdApp.Id);
                retrievedApp.Status.Should().Be("ACTIVE");
            }
            finally
            {
                await client.Applications.DeactivateApplicationAsync(createdApp.Id);
                await client.Applications.DeleteApplicationAsync(createdApp.Id);
            }
        }

        [Fact]
        public async Task CreateAssignUserForSSOApplication()
        {
            var client = TestClient.Create();
            var guid = Guid.NewGuid();

            // Create a user
            var createdUser = await client.Users.CreateUserAsync(new CreateUserWithPasswordOptions
            {
                Profile = new UserProfile
                {
                    FirstName = "John",
                    LastName = "Okta",
                    Email = $"john-sso-dotnet-sdk-{guid}@example.com",
                    Login = $"john-sso-dotnet-sdk-{guid}@example.com",
                },
                Password = "Abcd1234",
                Activate = true,
            });

            var createdApp = await client.Applications.CreateApplicationAsync(
                new CreateBasicAuthApplicationOptions()
                {
                    Label = $"dotnet-sdk: CreateAssignUserForSSOApplication {guid}",
                    Url = "https://example.com/login.html",
                    AuthUrl = "https://example.com/auth.html",
                });

            var assignUserOptions = new AssignUserToApplicationOptions()
            {
                UserId = createdUser.Id,
                Password = "Abcd1234",
                UserName = createdUser.Profile.Email,
                ApplicationId = createdApp.Id,
            };

            try
            {
                var createdAppUser = await client.Applications.AssignUserToApplicationAsync(assignUserOptions);

                createdAppUser.Scope.Should().Be("USER");
                createdAppUser.Credentials.UserName.Should().Be($"john-sso-dotnet-sdk-{guid}@example.com");
                createdAppUser.Status.Should().Be("ACTIVE");
                createdAppUser.SyncState.Should().Be("DISABLED");
            }
            finally
            {
                // Remove the user
                await createdUser.DeactivateAsync();
                await createdUser.DeactivateOrDeleteAsync();
                // Remove App
                await client.Applications.DeactivateApplicationAsync(createdApp.Id);
                await client.Applications.DeleteApplicationAsync(createdApp.Id);
            }
        }

        [Fact(Skip = "https://github.com/okta/okta.github.io/issues/2167")]
        public async Task CreateAssignUserForSSOApplicationAndProvisioning()
        {
            var client = TestClient.Create();
            var guid = Guid.NewGuid();

            // Create a user
            var createdUser = await client.Users.CreateUserAsync(new CreateUserWithPasswordOptions
            {
                Profile = new UserProfile
                {
                    FirstName = "John",
                    LastName = "Okta",
                    Email = $"john-sso-provisioning-dotnet-sdk-{guid}@example.com",
                    Login = $"john-sso-provisioning-dotnet-sdk-{guid}@example.com",
                },
                Password = "Abcd1234",
                Activate = true,
            });

            var createdApp = await client.Applications.CreateApplicationAsync(
                new CreateBasicAuthApplicationOptions()
                {
                    Label = $"dotnet-sdk:CreateAssignUserForSSOApplicationAndProvisioning {guid}",
                    Url = "https://example.com/login.html",
                    AuthUrl = "https://example.com/auth.html",
                });

            var profile = new Resource();
            profile["salesforceGroups"] = new List<string> { "Employee" };
            profile["role"] = "Developer";
            profile["profile"] = "Standard User";

            var assignUserOptions = new AssignUserToApplicationOptions()
            {
                UserId = createdUser.Id,
                Password = "Abcd1234",
                UserName = createdUser.Profile.Email,
                ApplicationId = createdApp.Id,
                Profile = profile,
            };

            try
            {
                var createdAppUser = await client.Applications.AssignUserToApplicationAsync(assignUserOptions);

                createdAppUser.Scope.Should().Be("USER");
                createdAppUser.Credentials.UserName.Should().Be($"john-sso-provisioning-dotnet-sdk-{guid}@example.com");
                createdAppUser.Status.Should().Be("PROVISIONED");
                createdAppUser.SyncState.Should().Be("DISABLED");
            }
            finally
            {
                // Remove the user
                await createdUser.DeactivateAsync();
                await createdUser.DeactivateOrDeleteAsync();
                // Remove App
                await client.Applications.DeactivateApplicationAsync(createdApp.Id);
                await client.Applications.DeleteApplicationAsync(createdApp.Id);
            }
        }

        [Fact]
        public async Task GetAssignedUsersForApplication()
        {
            var client = TestClient.Create();
            var guid = Guid.NewGuid();

            // Create a user
            var createdUser = await client.Users.CreateUserAsync(new CreateUserWithPasswordOptions
            {
                Profile = new UserProfile
                {
                    FirstName = "John",
                    LastName = "Okta",
                    Email = $"john-assigned-user-dotnet-sdk-{guid}@example.com",
                    Login = $"john-assigned-user-dotnet-sdk-{guid}@example.com",
                },
                Password = "Abcd1234",
                Activate = true,
            });

            var createdApp = await client.Applications.CreateApplicationAsync(
                new CreateBasicAuthApplicationOptions()
                {
                    Label = $"dotnet-sdk: GetAssignedUsersForApplication {guid}",
                    Url = "https://example.com/login.html",
                    AuthUrl = "https://example.com/auth.html",
                });

            var assignUserOptions = new AssignUserToApplicationOptions()
            {
                UserId = createdUser.Id,
                Password = "Abcd1234",
                UserName = createdUser.Profile.Email,
                ApplicationId = createdApp.Id,
            };

            try
            {
                var createdAppUser = await client.Applications.AssignUserToApplicationAsync(assignUserOptions);
                var retrievedAppUser = await createdApp.GetApplicationUserAsync(createdUser.Id);

                retrievedAppUser.Should().NotBeNull();
                retrievedAppUser.Id.Should().Be(createdAppUser.Id);
                retrievedAppUser.Scope.Should().Be("USER");
                retrievedAppUser.Credentials.UserName.Should().Be($"john-assigned-user-dotnet-sdk-{guid}@example.com");
            }
            finally
            {
                // Remove the user
                await createdUser.DeactivateAsync();
                await createdUser.DeactivateOrDeleteAsync();
                // Remove App
                await client.Applications.DeactivateApplicationAsync(createdApp.Id);
                await client.Applications.DeleteApplicationAsync(createdApp.Id);
            }
        }

        [Fact]
        public async Task ListUsersForApplication()
        {
            var client = TestClient.Create();
            var guid = Guid.NewGuid();

            // Create a user
            var createdUser1 = await client.Users.CreateUserAsync(new CreateUserWithPasswordOptions
            {
                Profile = new UserProfile
                {
                    FirstName = "John",
                    LastName = "Okta",
                    Email = $"john-list-users-dotnet-sdk-{guid}@example.com",
                    Login = $"john-list-users-dotnet-sdk-{guid}@example.com",
                },
                Password = "Abcd1234",
                Activate = true,
            });

            var createdUser2 = await client.Users.CreateUserAsync(new CreateUserWithPasswordOptions
            {
                Profile = new UserProfile
                {
                    FirstName = "Bob",
                    LastName = "Okta",
                    Email = $"bob-list-users-dotnet-sdk-{guid}@example.com",
                    Login = $"bob-list-users-dotnet-sdk-{guid}@example.com",
                },
                Password = "Abcd4321",
                Activate = true,
            });

            var createdApp = await client.Applications.CreateApplicationAsync(
                new CreateBasicAuthApplicationOptions()
                {
                    Label = $"dotnet-sdk: ListUsersForApplication {guid}",
                    Url = "https://example.com/login.html",
                    AuthUrl = "https://example.com/auth.html",
                });

            var assignUserOptions1 = new AssignUserToApplicationOptions()
            {
                UserId = createdUser1.Id,
                Password = "Abcd1234",
                UserName = createdUser1.Profile.Email,
                ApplicationId = createdApp.Id,
            };

            var assignUserOptions2 = new AssignUserToApplicationOptions()
            {
                UserId = createdUser2.Id,
                Password = "Abcd4321",
                UserName = createdUser2.Profile.Email,
                ApplicationId = createdApp.Id,
            };

            try
            {
                var createdAppUser1 = await client.Applications.AssignUserToApplicationAsync(assignUserOptions1);
                var createdAppUser2 = await client.Applications.AssignUserToApplicationAsync(assignUserOptions2);

                var appUserList = await createdApp.ListApplicationUsers().ToListAsync();

                appUserList.Should().NotBeNullOrEmpty();
                appUserList.Should().HaveCount(2);
                appUserList.FirstOrDefault(x => x.Credentials.UserName == createdUser1.Profile.Email).Should().NotBeNull();
                appUserList.FirstOrDefault(x => x.Credentials.UserName == createdUser2.Profile.Email).Should().NotBeNull();
            }
            finally
            {
                await createdUser1.DeactivateAsync();
                await createdUser1.DeactivateOrDeleteAsync();
                await createdUser2.DeactivateAsync();
                await createdUser2.DeactivateOrDeleteAsync();

                await client.Applications.DeactivateApplicationAsync(createdApp.Id);
                await client.Applications.DeleteApplicationAsync(createdApp.Id);
            }
        }

        [Fact]
        public async Task UpdateApplicationCredentialsForAssignedUser()
        {
            var client = TestClient.Create();
            var guid = Guid.NewGuid();

            // Create a user
            var createdUser = await client.Users.CreateUserAsync(new CreateUserWithPasswordOptions
            {
                Profile = new UserProfile
                {
                    FirstName = "John",
                    LastName = "Okta",
                    Email = $"john-update-credentials-dotnet-sdk-{guid}@example.com",
                    Login = $"john-update-credentials-dotnet-sdk-{guid}@example.com",
                },
                Password = "Abcd1234",
                Activate = true,
            });

            var createdApp = await client.Applications.CreateApplicationAsync(
                new CreateBasicAuthApplicationOptions()
                {
                    Label = $"dotnet-sdk: UpdateApplicationCredentialsForAssignedUser {guid}",
                    Url = "https://example.com/login.html",
                    AuthUrl = "https://example.com/auth.html",
                });

            var assignUserOptions = new AssignUserToApplicationOptions()
            {
                UserId = createdUser.Id,
                Password = "Abcd1234",
                UserName = createdUser.Profile.Email,
                ApplicationId = createdApp.Id,
            };

            try
            {
                var createdAppUser = await client.Applications.AssignUserToApplicationAsync(assignUserOptions);
                var retrievedAppUser = await createdApp.GetApplicationUserAsync(createdUser.Id);

                retrievedAppUser.Should().NotBeNull();
                retrievedAppUser.Id.Should().Be(createdAppUser.Id);
                retrievedAppUser.Scope.Should().Be("USER");
                retrievedAppUser.Credentials.UserName.Should().Be($"john-update-credentials-dotnet-sdk-{guid}@example.com");

                // Update credentials
                retrievedAppUser.Credentials.UserName = "$john-updated-credentials-updated-dotnet-sdk-{guid}@example.com";
                retrievedAppUser.Credentials.Password = new AppUserPasswordCredential() { Value = "Abcd12345" };

                var updatedAppUser = await client.Applications.UpdateApplicationUserAsync(retrievedAppUser, createdApp.Id, createdUser.Id);

                updatedAppUser.Should().NotBeNull();
                updatedAppUser.Credentials.UserName.Should().Be("$john-updated-credentials-updated-dotnet-sdk-{guid}@example.com");
            }
            finally
            {
                // Remove the user
                await createdUser.DeactivateAsync();
                await createdUser.DeactivateOrDeleteAsync();
                // Remove App
                await client.Applications.DeactivateApplicationAsync(createdApp.Id);
                await client.Applications.DeleteApplicationAsync(createdApp.Id);
            }
        }

        [Fact]
        public async Task RemoveUserForApplication()
        {
            var client = TestClient.Create();
            var guid = Guid.NewGuid();

            // Create a user
            var createdUser = await client.Users.CreateUserAsync(new CreateUserWithPasswordOptions
            {
                Profile = new UserProfile
                {
                    FirstName = "John",
                    LastName = "Okta",
                    Email = $"john-remove-user-dotnet-sdk-{guid}@example.com",
                    Login = $"john-remove-user-dotnet-sdk-{guid}@example.com",
                },
                Password = "Abcd1234",
                Activate = true,
            });

            var createdApp = await client.Applications.CreateApplicationAsync(
                new CreateBasicAuthApplicationOptions()
                {
                    Label = $"dotnet-sdk: RemoveUserForApplication {guid}",
                    Url = "https://example.com/login.html",
                    AuthUrl = "https://example.com/auth.html",
                });

            var assignUserOptions = new AssignUserToApplicationOptions()
            {
                UserId = createdUser.Id,
                Password = "Abcd1234",
                UserName = createdUser.Profile.Email,
                ApplicationId = createdApp.Id,
            };

            try
            {
                var createdAppUser = await client.Applications.AssignUserToApplicationAsync(assignUserOptions);
                var retrievedAppUser = await createdApp.GetApplicationUserAsync(createdUser.Id);

                retrievedAppUser.Should().NotBeNull();
                retrievedAppUser.Id.Should().Be(createdAppUser.Id);
                retrievedAppUser.Scope.Should().Be("USER");
                retrievedAppUser.Credentials.UserName.Should().Be($"john-remove-user-dotnet-sdk-{guid}@example.com");

                await client.Applications.DeleteApplicationUserAsync(createdApp.Id, createdUser.Id);

                var appUserList = await createdApp.ListApplicationUsers().ToListAsync<IAppUser>();
                appUserList.Should().BeNullOrEmpty();
            }
            finally
            {
                // Remove the user
                await createdUser.DeactivateAsync();
                await createdUser.DeactivateOrDeleteAsync();
                // Remove App
                await client.Applications.DeactivateApplicationAsync(createdApp.Id);
                await client.Applications.DeleteApplicationAsync(createdApp.Id);
            }
        }

        [Fact]
        public async Task AssignGroupForApplication()
        {
            var client = TestClient.Create();
            var guid = Guid.NewGuid();

            var createdGroup = await client.Groups.CreateGroupAsync(new CreateGroupOptions
            {
                Name = $"dotnet-sdk: AssignGroupForApplication {guid}",
            });

            var createdApp = await client.Applications.CreateApplicationAsync(
                new CreateBasicAuthApplicationOptions()
                {
                    Label = $"dotnet-sdk: AssignGroupForApplication {guid}",
                    Url = "https://example.com/login.html",
                    AuthUrl = "https://example.com/auth.html",
                });
            try
            {
                var groupAssignmentOptions = new CreateApplicationGroupAssignmentOptions()
                {
                    Priority = 0,
                    ApplicationId = createdApp.Id,
                    GroupId = createdGroup.Id,
                };

                var createdAppGroup = await client.Applications.CreateApplicationGroupAssignmentAsync(groupAssignmentOptions);
                var retrievedAppGroup = await client.Applications.GetApplicationGroupAssignmentAsync(createdApp.Id, createdGroup.Id);

                retrievedAppGroup.Should().NotBeNull();
                retrievedAppGroup.Id.Should().Be(createdAppGroup.Id);
                retrievedAppGroup.Priority.Should().Be(0);
            }
            finally
            {
                // Remove the group
                await createdGroup.DeleteAsync();
                // Remove App
                await client.Applications.DeactivateApplicationAsync(createdApp.Id);
                await client.Applications.DeleteApplicationAsync(createdApp.Id);
            }
        }

        [Fact]
        public async Task GetAssignmentGroupForApplication()
        {
            var client = TestClient.Create();
            var guid = Guid.NewGuid();

            var createdGroup = await client.Groups.CreateGroupAsync(new CreateGroupOptions
            {
                Name = $"dotnet-sdk: GetAssignmentGroupForApplication {guid}",
            });

            var createdApp = await client.Applications.CreateApplicationAsync(
                new CreateBasicAuthApplicationOptions()
                {
                    Label = $"dotnet-sdk: GetAssignmentGroupForApplication {guid}",
                    Url = "https://example.com/login.html",
                    AuthUrl = "https://example.com/auth.html",
                });
            try
            {
                var groupAssignmentOptions = new CreateApplicationGroupAssignmentOptions()
                {
                    Priority = 0,
                    ApplicationId = createdApp.Id,
                    GroupId = createdGroup.Id,
                };
                var createdAppGroup = await client.Applications.CreateApplicationGroupAssignmentAsync(groupAssignmentOptions);
                var retrievedAssignmentGroup = await createdApp.GetApplicationGroupAssignmentAsync(createdGroup.Id);

                retrievedAssignmentGroup.Should().NotBeNull();
                retrievedAssignmentGroup.Id.Should().Be(createdAppGroup.Id);
                retrievedAssignmentGroup.Priority.Should().Be(0);
            }
            finally
            {
                // Remove the group
                await createdGroup.DeleteAsync();
                // Remove App
                await client.Applications.DeactivateApplicationAsync(createdApp.Id);
                await client.Applications.DeleteApplicationAsync(createdApp.Id);
            }
        }

        [Fact]
        public async Task ListAssignmentGroupsForApplication()
        {
            var client = TestClient.Create();
            var guid = Guid.NewGuid();

            var createdGroup1 = await client.Groups.CreateGroupAsync(new CreateGroupOptions
            {
                Name = $"dotnet-sdk: ListAssignmentGroupsForApplication 1 {guid}",
            });

            var createdGroup2 = await client.Groups.CreateGroupAsync(new CreateGroupOptions
            {
                Name = $"dotnet-sdk: ListAssignmentGroupsForApplication 2 {guid}",
            });

            var createdApp = await client.Applications.CreateApplicationAsync(
                new CreateBasicAuthApplicationOptions()
                {
                    Label = $"dotnet-sdk: ListAssignmentGroupsForApplication {guid}",
                    Url = "https://example.com/login.html",
                    AuthUrl = "https://example.com/auth.html",
                });
            try
            {
                var groupAssignmentOptions1 = new CreateApplicationGroupAssignmentOptions()
                {
                    Priority = 0,
                    ApplicationId = createdApp.Id,
                    GroupId = createdGroup1.Id,
                };

                var groupAssignmentOptions2 = new CreateApplicationGroupAssignmentOptions()
                {
                    Priority = 0,
                    ApplicationId = createdApp.Id,
                    GroupId = createdGroup2.Id,
                };

                var createdAppGroup1 = await client.Applications.CreateApplicationGroupAssignmentAsync(groupAssignmentOptions1);
                var createdAppGroup2 = await client.Applications.CreateApplicationGroupAssignmentAsync(groupAssignmentOptions2);

                var groupAssignmentList = await createdApp.ListGroupAssignments().ToListAsync<IApplicationGroupAssignment>();

                groupAssignmentList.Should().NotBeNullOrEmpty();
                groupAssignmentList.Should().HaveCount(2);
                groupAssignmentList.FirstOrDefault(x => x.Id == createdAppGroup1.Id).Should().NotBeNull();
                groupAssignmentList.FirstOrDefault(x => x.Id == createdAppGroup2.Id).Should().NotBeNull();
            }
            finally
            {
                // Remove the groups
                await createdGroup1.DeleteAsync();
                await createdGroup2.DeleteAsync();
                // Remove App
                await client.Applications.DeactivateApplicationAsync(createdApp.Id);
                await client.Applications.DeleteApplicationAsync(createdApp.Id);
            }
        }

        [Fact]
        public async Task RemoveGroupForApplication()
        {
            var client = TestClient.Create();
            var guid = Guid.NewGuid();

            var createdGroup = await client.Groups.CreateGroupAsync(new CreateGroupOptions
            {
                Name = $"dotnet-sdk: RemoveGroupForApplication {guid}",
            });

            var createdApp = await client.Applications.CreateApplicationAsync(
                new CreateBasicAuthApplicationOptions()
                {
                    Label = $"dotnet-sdk: RemoveGroupForApplication {guid}",
                    Url = "https://example.com/login.html",
                    AuthUrl = "https://example.com/auth.html",
                });
            try
            {
                var groupAssignmentOptions = new CreateApplicationGroupAssignmentOptions()
                {
                    Priority = 0,
                    ApplicationId = createdApp.Id,
                    GroupId = createdGroup.Id,
                };

                var createdAppGroup = await client.Applications.CreateApplicationGroupAssignmentAsync(groupAssignmentOptions);

                var retrievedAssignmentGroup = await createdApp.GetApplicationGroupAssignmentAsync(createdGroup.Id);
                retrievedAssignmentGroup.Should().NotBeNull();
                retrievedAssignmentGroup.Id.Should().Be(createdAppGroup.Id);

                await client.Applications.DeleteApplicationGroupAssignmentAsync(createdApp.Id, createdGroup.Id);

                var appGroupAssignmentList = await createdApp.ListGroupAssignments().ToListAsync<IApplicationGroupAssignment>();
                appGroupAssignmentList.Should().BeNullOrEmpty();
            }
            finally
            {
                // Remove the group
                await createdGroup.DeleteAsync();
                // Remove App
                await client.Applications.DeactivateApplicationAsync(createdApp.Id);
                await client.Applications.DeleteApplicationAsync(createdApp.Id);
            }
        }

        [Fact]
        public async Task ListApplicationKeyCredentials()
        {
            var client = TestClient.Create();
            var guid = Guid.NewGuid();

            var createdApp = await client.Applications.CreateApplicationAsync(
                new CreateBasicAuthApplicationOptions()
                {
                    Label = $"dotnet-sdk: ListApplicationKeyCredentials {guid}",
                    Url = "https://example.com/login.html",
                    AuthUrl = "https://example.com/auth.html",
                });

            try
            {
                var appKeys = await createdApp.ListKeys().ToListAsync();
                // A key is created by default
                appKeys.Should().NotBeNull();
                appKeys.Should().HaveCount(1);
            }
            finally
            {
                await client.Applications.DeactivateApplicationAsync(createdApp.Id);
                await client.Applications.DeleteApplicationAsync(createdApp.Id);
            }
        }

        [Fact]
        public async Task GetApplicationKeyCredentials()
        {
            var client = TestClient.Create();
            var guid = Guid.NewGuid();

            var createdApp = await client.Applications.CreateApplicationAsync(
                new CreateBasicAuthApplicationOptions()
                {
                    Label = $"dotnet-sdk: GetApplicationKeyCredentials {guid}",
                    Url = "https://example.com/login.html",
                    AuthUrl = "https://example.com/auth.html",
                });

            try
            {
                var defaultAppKey = await createdApp.ListKeys().FirstOrDefaultAsync();
                var retrievedAppKey = await createdApp.GetApplicationKeyAsync(defaultAppKey.Kid);

                retrievedAppKey.Should().NotBeNull();
                retrievedAppKey.Kid.Should().Be(defaultAppKey.Kid);
                retrievedAppKey.Created.Should().Be(defaultAppKey.Created);
                retrievedAppKey.ExpiresAt.Should().Be(defaultAppKey.ExpiresAt);
                retrievedAppKey.X5C.Should().BeEquivalentTo(defaultAppKey.X5C);
            }
            finally
            {
                await client.Applications.DeactivateApplicationAsync(createdApp.Id);
                await client.Applications.DeleteApplicationAsync(createdApp.Id);
            }
        }

        [Fact]
        public async Task GenerateApplicationKey()
        {
            var client = TestClient.Create();
            var guid = Guid.NewGuid();

            var createdApp = await client.Applications.CreateApplicationAsync(
                new CreateBasicAuthApplicationOptions()
                {
                    Label = $"dotnet-sdk: GenerateApplicationKeyCredentials {guid}",
                    Url = "https://example.com/login.html",
                    AuthUrl = "https://example.com/auth.html",
                });

            try
            {
                var generatedKey = await createdApp.GenerateKeyAsync(2);

                var retrievedAppKey = await createdApp.GetApplicationKeyAsync(generatedKey.Kid);

                retrievedAppKey.Should().NotBeNull();
                retrievedAppKey.Created.Should().Be(generatedKey.Created);
                retrievedAppKey.ExpiresAt.Should().Be(generatedKey.ExpiresAt);
                retrievedAppKey.X5C.Should().BeEquivalentTo(generatedKey.X5C);
            }
            finally
            {
                await client.Applications.DeactivateApplicationAsync(createdApp.Id);
                await client.Applications.DeleteApplicationAsync(createdApp.Id);
            }
        }

        [Fact]
        public async Task CloneApplicationKey()
        {
            var client = TestClient.Create();
            var guid = Guid.NewGuid();

            var createdApp1 = await client.Applications.CreateApplicationAsync(
                new CreateBasicAuthApplicationOptions()
                {
                    Label = $"dotnet-sdk: CloneApplicationKeyCredentials1 {guid}",
                    Url = "https://example.com/login.html",
                    AuthUrl = "https://example.com/auth.html",
                });

            var createdApp2 = await client.Applications.CreateApplicationAsync(
                new CreateBasicAuthApplicationOptions()
                {
                    Label = $"dotnet-sdk: CloneApplicationKeyCredentials2 {guid}",
                    Url = "https://example.com/login.html",
                    AuthUrl = "https://example.com/auth.html",
                });

            try
            {
                var generatedKey1 = await createdApp1.GenerateKeyAsync(2);

                var clonedKey2 = await createdApp1.CloneApplicationKeyAsync(generatedKey1.Kid, createdApp2.Id);

                clonedKey2.Should().NotBeNull();
                clonedKey2.Kid.Should().Be(generatedKey1.Kid);
                clonedKey2.ExpiresAt.Should().Be(generatedKey1.ExpiresAt);
                clonedKey2.X5C.Should().BeEquivalentTo(generatedKey1.X5C);
            }
            finally
            {
                await client.Applications.DeactivateApplicationAsync(createdApp1.Id);
                await client.Applications.DeleteApplicationAsync(createdApp1.Id);
                await client.Applications.DeactivateApplicationAsync(createdApp2.Id);
                await client.Applications.DeleteApplicationAsync(createdApp2.Id);
            }
        }

        [Fact]
        public async Task GenerateCsr()
        {
            var client = TestClient.Create();
            var guid = Guid.NewGuid();

            var createdApp = await client.Applications.CreateApplicationAsync(
                new CreateBasicAuthApplicationOptions()
                {
                    Label = $"dotnet-sdk: GenerateCsr {guid}",
                    Url = "https://example.com/login.html",
                    AuthUrl = "https://example.com/auth.html",
                });

            try
            {
                var csrMetadata = new CsrMetadata()
                {
                    Subject = new CsrMetadataSubject()
                    {
                        CountryName = "US",
                        StateOrProvinceName = "California",
                        LocalityName = "San Francisco",
                        OrganizationName = "Okta, Inc.",
                        OrganizationalUnitName = "Dev",
                        CommonName = "SP Issuer",
                    },
                    SubjectAltNames = new CsrMetadataSubjectAltNames()
                    {
                        DnsNames = new List<string>() { "dev.okta.com" },
                    },
                };

                var generatedCsr = await createdApp.GenerateCsrAsync(csrMetadata);

                generatedCsr.Should().NotBeNull();
                generatedCsr.Kty.Should().Be("RSA");
                generatedCsr.CsrValue.Should().NotBeNullOrEmpty();
            }
            finally
            {
                await client.Applications.DeactivateApplicationAsync(createdApp.Id);
                await client.Applications.DeleteApplicationAsync(createdApp.Id);
            }
        }

        [Fact]
        public async Task GetCsr()
        {
            var client = TestClient.Create();
            var guid = Guid.NewGuid();

            var createdApp = await client.Applications.CreateApplicationAsync(
                new CreateBasicAuthApplicationOptions()
                {
                    Label = $"dotnet-sdk: GetCsr {guid}",
                    Url = "https://example.com/login.html",
                    AuthUrl = "https://example.com/auth.html",
                });

            try
            {
                var csrMetadata = new CsrMetadata()
                {
                    Subject = new CsrMetadataSubject()
                    {
                        CountryName = "US",
                        StateOrProvinceName = "California",
                        LocalityName = "San Francisco",
                        OrganizationName = "Okta, Inc.",
                        OrganizationalUnitName = "Dev",
                        CommonName = "SP Issuer",
                    },
                    SubjectAltNames = new CsrMetadataSubjectAltNames()
                    {
                        DnsNames = new List<string>() { "dev.okta.com" },
                    },
                };

                var generatedCsr = await createdApp.GenerateCsrAsync(csrMetadata);

                var retrievedCsr = await createdApp.GetCsrAsync(generatedCsr.Id);
                retrievedCsr.Should().NotBeNull();
            }
            finally
            {
                await client.Applications.DeactivateApplicationAsync(createdApp.Id);
                await client.Applications.DeleteApplicationAsync(createdApp.Id);
            }
        }

        [Fact]
        public async Task RevokeCsr()
        {
            var client = TestClient.Create();
            var guid = Guid.NewGuid();

            var createdApp = await client.Applications.CreateApplicationAsync(
                new CreateBasicAuthApplicationOptions()
                {
                    Label = $"dotnet-sdk: RevokeCsr {guid}",
                    Url = "https://example.com/login.html",
                    AuthUrl = "https://example.com/auth.html",
                });

            try
            {
                var csrMetadata = new CsrMetadata()
                {
                    Subject = new CsrMetadataSubject()
                    {
                        CountryName = "US",
                        StateOrProvinceName = "California",
                        LocalityName = "San Francisco",
                        OrganizationName = "Okta, Inc.",
                        OrganizationalUnitName = "Dev",
                        CommonName = "SP Issuer",
                    },
                    SubjectAltNames = new CsrMetadataSubjectAltNames()
                    {
                        DnsNames = new List<string>() { "dev.okta.com" },
                    },
                };

                var generatedCsr = await createdApp.GenerateCsrAsync(csrMetadata);

                var retrievedCsr = await createdApp.ListCsrs().Where(x => x.Id == generatedCsr.Id).FirstOrDefaultAsync();
                retrievedCsr.Should().NotBeNull();

                await createdApp.RevokeCsrAsync(generatedCsr.Id);

                retrievedCsr = await createdApp.ListCsrs().Where(x => x.Id == generatedCsr.Id).FirstOrDefaultAsync();
                retrievedCsr.Should().BeNull();
            }
            finally
            {
                await client.Applications.DeactivateApplicationAsync(createdApp.Id);
                await client.Applications.DeleteApplicationAsync(createdApp.Id);
            }
        }

        [Fact]
        public async Task GrantConsentToScope()
        {
            var client = TestClient.Create();
            var guid = Guid.NewGuid();
            var testClientId = $"{nameof(GrantConsentToScope)}_TestClientId_{guid}";

            var createdApp = await client.Applications.CreateApplicationAsync(new CreateOpenIdConnectApplication
            {
                Label = $"dotnet-sdk: GrantConsentToScope {guid}",
                ClientId = testClientId,
                TokenEndpointAuthMethod = OAuthEndpointAuthenticationMethod.ClientSecretPost,
                AutoKeyRotation = true,
                ClientUri = "https://example.com/client",
                LogoUri = "https://example.com/assets/images/logo-new.png",
                ResponseTypes = new List<OAuthResponseType>
                {
                    OAuthResponseType.Token,
                    OAuthResponseType.IdToken,
                    OAuthResponseType.Code,
                },
                RedirectUris = new List<string>
                {
                        "https://example.com/oauth2/callback",
                        "myapp://callback",
                },
                PostLogoutRedirectUris = new List<string>
                {
                    "https://example.com/postlogout",
                    "myapp://postlogoutcallback",
                },
                GrantTypes = new List<OAuthGrantType>
                {
                    OAuthGrantType.Implicit,
                    OAuthGrantType.AuthorizationCode,
                },
                ApplicationType = OpenIdConnectApplicationType.Native,
                TermsOfServiceUri = "https://example.com/client/tos",
                PolicyUri = "https://example.com/client/policy",
            });
            try
            {
                var issuer = client.Configuration.OktaDomain.EndsWith("/") ?
                             client.Configuration.OktaDomain.Remove(client.Configuration.OktaDomain.Length - 1) : client.Configuration.OktaDomain;

                await createdApp.GrantConsentToScopeAsync(new OAuth2ScopeConsentGrant()
                {
                    Issuer = issuer,
                    ScopeId = "okta.users.read",
                });

                var appConsentGrants = await createdApp.ListScopeConsentGrants().ToListAsync();
                appConsentGrants.Should().NotBeNull();

                var retrievedConsent = appConsentGrants.FirstOrDefault(x => x.ScopeId == "okta.users.read" && x.Issuer == issuer);
                retrievedConsent.Should().NotBeNull();
            }
            finally
            {
                await client.Applications.DeactivateApplicationAsync(createdApp.Id);
                await client.Applications.DeleteApplicationAsync(createdApp.Id);
            }
        }

        [Fact]
        public async Task GetConsentGrant()
        {
            var client = TestClient.Create();
            var guid = Guid.NewGuid();
            var testClientId = $"{nameof(GetConsentGrant)}_TestClientId";

            var createdApp = await client.Applications.CreateApplicationAsync(new CreateOpenIdConnectApplication
            {
                Label = $"dotnet-sdk: GetConsentGrant {guid}",
                ClientId = testClientId,
                TokenEndpointAuthMethod = OAuthEndpointAuthenticationMethod.ClientSecretPost,
                AutoKeyRotation = true,
                ClientUri = "https://example.com/client",
                LogoUri = "https://example.com/assets/images/logo-new.png",
                ResponseTypes = new List<OAuthResponseType>
                {
                    OAuthResponseType.Token,
                    OAuthResponseType.IdToken,
                    OAuthResponseType.Code,
                },
                RedirectUris = new List<string>
                {
                        "https://example.com/oauth2/callback",
                        "myapp://callback",
                },
                PostLogoutRedirectUris = new List<string>
                {
                    "https://example.com/postlogout",
                    "myapp://postlogoutcallback",
                },
                GrantTypes = new List<OAuthGrantType>
                {
                    OAuthGrantType.Implicit,
                    OAuthGrantType.AuthorizationCode,
                },
                ApplicationType = OpenIdConnectApplicationType.Native,
                TermsOfServiceUri = "https://example.com/client/tos",
                PolicyUri = "https://example.com/client/policy",
            });
            try
            {
                var issuer = client.Configuration.OktaDomain.EndsWith("/") ?
                             client.Configuration.OktaDomain.Remove(client.Configuration.OktaDomain.Length - 1) : client.Configuration.OktaDomain;

                await createdApp.GrantConsentToScopeAsync(new OAuth2ScopeConsentGrant()
                {
                    Issuer = issuer,
                    ScopeId = "okta.users.read",
                });

                var retrievedConsentGrantFromList = await createdApp.ListScopeConsentGrants().FirstOrDefaultAsync(x => x.ScopeId == "okta.users.read" && x.Issuer == issuer);
                var retrievedConsentGrantFromGet = await createdApp.GetScopeConsentGrantAsync(retrievedConsentGrantFromList.Id);

                retrievedConsentGrantFromGet.Should().NotBeNull();
            }
            finally
            {
                await client.Applications.DeactivateApplicationAsync(createdApp.Id);
                await client.Applications.DeleteApplicationAsync(createdApp.Id);
            }
        }

        [Fact]
        public async Task RevokeConsentGrant()
        {
            var client = TestClient.Create();
            var guid = Guid.NewGuid();
            var testClientId = $"{nameof(RevokeConsentGrant)}_TestClientId";

            var createdApp = await client.Applications.CreateApplicationAsync(new CreateOpenIdConnectApplication
            {
                Label = $"dotnet-sdk: RevokeConsentGrant {guid}",
                ClientId = testClientId,
                TokenEndpointAuthMethod = OAuthEndpointAuthenticationMethod.ClientSecretPost,
                AutoKeyRotation = true,
                ClientUri = "https://example.com/client",
                LogoUri = "https://example.com/assets/images/logo-new.png",
                ResponseTypes = new List<OAuthResponseType>
                {
                    OAuthResponseType.Token,
                    OAuthResponseType.IdToken,
                    OAuthResponseType.Code,
                },
                RedirectUris = new List<string>
                {
                        "https://example.com/oauth2/callback",
                        "myapp://callback",
                },
                PostLogoutRedirectUris = new List<string>
                {
                    "https://example.com/postlogout",
                    "myapp://postlogoutcallback",
                },
                GrantTypes = new List<OAuthGrantType>
                {
                    OAuthGrantType.Implicit,
                    OAuthGrantType.AuthorizationCode,
                },
                ApplicationType = OpenIdConnectApplicationType.Native,
                TermsOfServiceUri = "https://example.com/client/tos",
                PolicyUri = "https://example.com/client/policy",
            });
            try
            {
                var issuer = client.Configuration.OktaDomain.EndsWith("/") ?
                             client.Configuration.OktaDomain.Remove(client.Configuration.OktaDomain.Length - 1) : client.Configuration.OktaDomain;

                await createdApp.GrantConsentToScopeAsync(new OAuth2ScopeConsentGrant()
                {
                    Issuer = issuer,
                    ScopeId = "okta.users.read",
                });

                var retrievedConsentGrant = await createdApp.ListScopeConsentGrants().FirstOrDefaultAsync(x => x.ScopeId == "okta.users.read" && x.Issuer == issuer);
                retrievedConsentGrant.Should().NotBeNull();

                await createdApp.RevokeScopeConsentGrantAsync(retrievedConsentGrant.Id);

                retrievedConsentGrant = await createdApp.ListScopeConsentGrants().FirstOrDefaultAsync(x => x.ScopeId == "okta.users.read" && x.Issuer == issuer);
                retrievedConsentGrant.Should().BeNull();
            }
            finally
            {
                await client.Applications.DeactivateApplicationAsync(createdApp.Id);
                await client.Applications.DeleteApplicationAsync(createdApp.Id);
            }
        }

        [Fact]
        public async Task UpdateApplicationProfile()
        {
            var oktaClient = TestClient.Create();
            var guid = Guid.NewGuid();

            var appCreateOptions = new CreateOpenIdConnectApplication
            {
                Label = $"dotnet-sdk: {nameof(UpdateApplicationProfile)} {guid}",
                Activate = true,
                ResponseTypes = new[] {OAuthResponseType.Code },
                GrantTypes = new[] { OAuthGrantType.AuthorizationCode, OAuthGrantType.ClientCredentials },
                ApplicationType = OpenIdConnectApplicationType.Service,
                RedirectUris = new[] { "https://example.com" },
            };

            var newApp = await oktaClient.Applications.CreateApplicationAsync(appCreateOptions);
            newApp.Profile = new Resource();
            newApp.Profile["somelist"] = new List<string> { "test" };

            try
            {
                await oktaClient.Applications.UpdateApplicationAsync(newApp, newApp.Id);
                var persistedApp = await oktaClient.Applications.GetApplicationAsync(newApp.Id);
                var listProperty = persistedApp.Profile.GetArrayProperty<string>("somelist");
                listProperty.Should().HaveCount(1);
                listProperty.First().Should().Be("test");
            }
            finally
            {
                // Remove App
                await oktaClient.Applications.DeactivateApplicationAsync(newApp.Id);
                await oktaClient.Applications.DeleteApplicationAsync(newApp.Id);
            }
        }

        [Fact]
        public async Task GetDefaultProvisioningConnection()
        {
            var oktaClient = TestClient.Create();
            var guid = Guid.NewGuid();

            var appCreateOptions = new CreateOpenIdConnectApplication
            {
                Label = $"dotnet-sdk: {nameof(UpdateApplicationProfile)} {guid}",
                Activate = true,
                ResponseTypes = new[] { OAuthResponseType.Code },
                GrantTypes = new[] { OAuthGrantType.AuthorizationCode, OAuthGrantType.ClientCredentials },
                ApplicationType = OpenIdConnectApplicationType.Service,
                RedirectUris = new[] { "https://example.com" },
            };

            var newApp = await oktaClient.Applications.CreateApplicationAsync(appCreateOptions);

            try
            {
                var connection = await oktaClient.Applications.GetDefaultProvisioningConnectionForApplicationAsync(newApp.Id);
                connection.AuthScheme.Should().Be(ProvisioningConnectionAuthScheme.Unknown);
                connection.Status.Should().Be(ProvisioningConnectionStatus.Unknown);
            }
            finally
            {
                // Remove App
                await oktaClient.Applications.DeactivateApplicationAsync(newApp.Id);
                await oktaClient.Applications.DeleteApplicationAsync(newApp.Id);
            }
        }

        [Fact]
        public async Task CreateOrg2OrgApplication()
        {
            var oktaClient = TestClient.Create();
            var guid = Guid.NewGuid();

            var org2orgApp = new Org2OrgApplication
            {
                Label = $"dotnet-sdk: okta_org2org {guid}",
                SignOnMode = ApplicationSignOnMode.Saml2,
                Name = "okta_org2org",
                Settings = new Org2OrgApplicationSettings
                {
                    App = new Org2OrgApplicationSettingsApp
                    {
                        AcsUrl = "https://example.okta.com/sso/saml2/exampleid",
                        AudRestriction = "https://www.okta.com/saml2/service-provider/exampleid",
                        BaseUrl = "https://example.okta.com",
                    },
                },
                Visibility = new ApplicationVisibility
                {
                    AutoLaunch = true,
                    AutoSubmitToolbar = true,
                },
            };

            var newApp = await oktaClient.Applications.CreateApplicationAsync(org2orgApp);

            try
            {
                newApp.Id.Should().NotBeNullOrEmpty();
                newApp.SignOnMode.Should().Be(ApplicationSignOnMode.Saml2);
                newApp.Name.Should().Be(org2orgApp.Name);
                newApp.Label.Should().Be(org2orgApp.Label);

                var retrievedApp = await oktaClient.Applications.GetApplicationAsync<IOrg2OrgApplication>(newApp.Id);
                retrievedApp.Should().NotBeNull();
            }
            finally
            {
                // Remove App
                await oktaClient.Applications.DeactivateApplicationAsync(newApp.Id);
                await oktaClient.Applications.DeleteApplicationAsync(newApp.Id);
            }
        }
    }
}
