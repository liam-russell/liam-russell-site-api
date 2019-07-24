using LiamRussell.Data.Models;
using System.Collections.Generic;

namespace LiamRussell.Data {
    /// <summary>
    /// This class defines my skills.
    /// </summary>
    /// <remarks>
    ///    I could have used a database to store this data, but keeping it in code has multiple benefits:
    ///    * Can be easily version controlled with Git
    ///    * Using C# with an IDE provides intellisense to allow for quick data entry
    ///    * No external database calls are needed, keeping things performant
    ///
    ///    Perhaps if my requirements change in the future this will be persisted to external storage of some sort.
    /// </remarks>
    public static class Skills {
        public static readonly IEnumerable<Skill> All = new [] {
            #region languages
            new Skill {
                Key = "dotnet",
                Name = "Dotnet core and .NET Framework (C#)",
                Categories = new [] { SkillCategories.Backend, SkillCategories.ProgrammingLanguages },
                Link = "https://dotnet.microsoft.com/",
                Proficiency = Proficiency.Proficient,
                Description = "I've worked with C# and Microsoft .NET professionally extensively," +
                " including both the legacy .NET Framework and the more modern dotnet core, " +
                "including deploying the latter serverlessly."
            },
            new Skill {
                Key = "javascript",
                Name = "JavaScript and TypeScript",
                Categories = new [] { SkillCategories.Frontend, SkillCategories.Backend, SkillCategories.ProgrammingLanguages },
                Link = "https://www.typescriptlang.org/",
                Proficiency = Proficiency.Proficient,
                Description = "I have experience with JavaScript in many contexts, preferring the more modern Typescript, " +
                "I've worked with JavaScript in both frontend and backend contexts.",
                RelatedSkillKeys = new [] {
                    "react",
                    "angular",
                    "bootstrap"
                }
            },
            new Skill {
                Key = "html",
                Name = "HTML5",
                Categories = new [] { SkillCategories.Frontend, SkillCategories.ProgrammingLanguages },
                Link = "https://developer.mozilla.org/en-US/docs/Web/Guide/HTML/HTML5",
                Proficiency = Proficiency.Proficient,
                RelatedSkillKeys = new [] {
                    "react",
                    "angular",
                    "bootstrap"
                }
            },
            new Skill {
                Key = "css",
                Name = "CSS, Less and SASS",
                Categories = new [] { SkillCategories.Frontend, SkillCategories.ProgrammingLanguages },
                Link = "https://sass-lang.com/",
                Proficiency = Proficiency.Proficient,
                Description = "I have a complete understanding of the CSS language. I have a working knowledge of the SASS (SCSS) and Less CSS precompilers.",
                RelatedSkillKeys = new [] {
                    "react",
                    "angular",
                    "bootstrap"
                }
            },
            new Skill {
                Key = "sql",
                Name = "SQL",
                Categories = new [] { SkillCategories.Databases, SkillCategories.Backend, SkillCategories.ProgrammingLanguages },
                Link = "https://en.wikipedia.org/wiki/Transact-SQL",
                Proficiency = Proficiency.Proficient,
                Description = "I've created many complex reports with Microsoft T-SQL and have additionally utilised" +
                " it extensively within an application development context. I am familiar with common ORM's" +
                " such as Entity Framework. I have some experience with other database systems such" +
                " as MySQL, SQLite and AWS DynamoDB."
            },
            #endregion
            #region frameworks
            new Skill {
                Key = "react",
                Name = "React",
                Categories = new [] { SkillCategories.Frontend, SkillCategories.Frameworks },
                Link = "https://reactjs.org/",
                Proficiency = Proficiency.Familiar,
                RelatedSkillKeys = new [] {
                    "javascript",
                    "html",
                    "css",
                    "netlify"
                }
            },
            new Skill {
                Key = "angular",
                Name = "Angular",
                Categories = new [] { SkillCategories.Frontend, SkillCategories.Frameworks },
                Link = "https://angular.io/",
                Proficiency= Proficiency.Familiar,
                Description = "I've created and contributed to several Angular-based projects. " +
                "As well as more modern versions of Angular I have experience with the legacy AngularJS.",
                RelatedSkillKeys = new [] {
                    "javascript",
                    "html",
                    "css",
                    "netlify"
                }
            },
            new Skill {
                Key = "mvc",
                Name = "Microsoft MVC + Web API",
                Categories = new [] { SkillCategories.Backend, SkillCategories.Frameworks },
                Link = "https://dotnet.microsoft.com/apps/aspnet/mvc",
                Proficiency = Proficiency.Proficient
            },
            new Skill {
                Key = "bootstrap",
                Name = "Bootstrap",
                Categories = new [] { SkillCategories.Frontend },
                Link = "https://getbootstrap.com/",
                Proficiency = Proficiency.Proficient,
                Description = "I am very familiar with Bootstrap 2 - 4, I have lead a team building a bootstrap-derivative framework with custom components and styling.",
                RelatedSkillKeys = new [] {
                    "javascript",
                    "html",
                    "css"
                }

            },
            #endregion
            #region cloud
            new Skill {
                Key = "sls",
                Name = "Serverless compute functions (AWS Lambda)",
                Categories = new [] { SkillCategories.Backend, SkillCategories.Cloud, SkillCategories.Servers },
                Link = "https://aws.amazon.com/serverless/",
                Proficiency = Proficiency.Proficient,
                Description = "I have experience with the AWS Lambda serverless platform, " +
                "and deploying scalable C# dotnet core, NodeJS and Python applications to it. " +
                "I'm a strong advocate for serverless technologies as a whole, and feel they will " +
                "play a central part in future web systems' architecture and best-practices. " +
                "Related tools and services include the Serverless Application Model and CloudFormation.",
                RelatedSkillKeys = new [] {
                    "aws"
                }
            },
            new Skill {
                Key = "aws",
                Name = "Amazon Web Services",
                Categories = new [] { SkillCategories.Cloud, SkillCategories.Backend, SkillCategories.Databases, SkillCategories.Servers, SkillCategories.DevOps },
                Link = "https://aws.amazon.com/",
                Proficiency = Proficiency.Proficient,
                Description = "I am familiar with many AWS Services",
                SubSkills = new [] {
                    new SubSkill("RDS - Relational Database Service", "https://aws.amazon.com/rds/"),
                    new SubSkill("S3 - Simple Email Service", "https://aws.amazon.com/s3/"),
                    new SubSkill("EC2 - Elastic Compute Cloud", "https://aws.amazon.com/ec2/"),
                    new SubSkill("DynamoDB - NoSQL Database", "https://aws.amazon.com/dynamodb/"),
                    new SubSkill("Lambda - Serverless Functions", "https://aws.amazon.com/lambda/"),
                    new SubSkill("Fargate - Managed Container Hosting", "https://aws.amazon.com/fargate/"),
                    new SubSkill("ECS - Elastic Container Service", "https://aws.amazon.com/ecs/"),
                    new SubSkill("CodeBuild - DevOps - Continuous Integration", "https://aws.amazon.com/codebuild/"),
                    new SubSkill("CloudFormation - Cloud Scaffolding and Delivery", "https://aws.amazon.com/cloudformation/"),
                    new SubSkill("SAM - Serverless Application Model", "https://github.com/awslabs/serverless-application-model"),
                    new SubSkill("API Gateway", "https://aws.amazon.com/apigateway/"),
                    new SubSkill("IAM - Identity and Access Management", "https://aws.amazon.com/iam/"),
                    new SubSkill("IoT - Internet of Things", "https://aws.amazon.com/iot/"),
                    new SubSkill("Cognito - Authentication Platform", "https://aws.amazon.com/cognito/"),
                    new SubSkill("Connect - Cloud Call Center", "https://aws.amazon.com/connect/"),
                    new SubSkill("SNS - Simple Notification Service", "https://aws.amazon.com/sns/"),
                    new SubSkill("SES - Simple Email Service", "https://aws.amazon.com/ses/"),
                    new SubSkill("CloudWatch", "https://aws.amazon.com/cloudwatch/")
                },
                RelatedSkillKeys = new [] {
                    "sls",
                    "cicd"
                }
            },
            new Skill {
                Key = "netlify",
                Name = "Netlify",
                Categories = new [] { SkillCategories.Cloud, SkillCategories.Frontend, SkillCategories.DevOps },
                Link = "https://www.netlify.com/",
                Proficiency = Proficiency.Proficient,
                Description = "Netlify is my preferred method for building and deploying single page web apps.",
                RelatedSkillKeys = new [] {
                    "react",
                    "angular",
                    "cicd"
                }
            },
            #endregion
            #region management
            new Skill {
                Key = "agile",
                Name = "Agile software development",
                Categories = new [] { SkillCategories.Management },
                Link = "https://www.atlassian.com/agile",
                Proficiency = Proficiency.Proficient,
                Description = "I have participated and help lead development using agile software development methodologies.",
                RelatedSkillKeys = new [] {
                    "agile"
                }
            },
            new Skill {
                Key = "jira",
                Name = "Atlassian Jira",
                Categories = new [] { SkillCategories.Management },
                Proficiency = Proficiency.Proficient,
                Link = "https://www.atlassian.com/software/jira",
                Description = "I have solid knowledge of Atlassian's Jira for managing projects, development tasks and sprints.",
                RelatedSkillKeys = new [] {
                    "jira"
                }
            },
            #endregion
            #region devops
            new Skill {
                Key = "cicd",
                Name = "Continuous Integration, Delivery and Deployment",
                Link = "https://www.atlassian.com/continuous-delivery/principles/continuous-integration-vs-delivery-vs-deployment",
                Proficiency = Proficiency.Proficient,
                Categories = new [] { SkillCategories.DevOps, SkillCategories.Cloud },
                SubSkills = new [] {
                    new SubSkill("AWS CodeBuild", "https://aws.amazon.com/codebuild/"),
                    new SubSkill("GoCD", "https://www.gocd.org/"),
                    new SubSkill("Jenkins", "https://jenkins.io/"),
                    new SubSkill("TeamCity", "https://www.jetbrains.com/teamcity/"),
                    new SubSkill("CodeShip", "https://codeship.com/"),
                    new SubSkill("CircleCI", "https://circleci.com/"),
                    new SubSkill("Travis", "https://travis-ci.org/"),
                    new SubSkill("Netlify", "https://www.netlify.com/"),
                },
                Description = "I've configured multiple projects for build, test and deploy via multiple CI platforms. My preference is container-based build platforms.",
                RelatedSkillKeys = new [] {
                    "netlify",
                    "aws"
                }
            }
            #endregion
        };
    }
}
