pipeline {
    agent any
   
    environment {
        DOTNET_SYSTEM_GLOBALIZATION_INVARIANT='true'
        PATH = "/var/jenkins_home/tools/io.jenkins.plugins.dotnet.DotNetSDK/dotnet::$PATH"
  }
    
    stages {
        stage('Checkout') {
            steps {
                checkout scm
            }
        }
        stage('Build') {
            steps {
               echo "helo"
            }
        }
        stage('CodeAnalysis') {
            steps {
                  withSonarQubeEnv('sonar')
                {
                  sh "dotnet sonarscanner begin /k:test"
                  sh "dotnet build "
                  sh "dotnet sonarscanner end "
                }
            }
        }
        stage('Test') {
            steps {
                echo 'Testing..'
            }
        }
        stage('Deploy') {
            steps {
                echo 'Deploying....'
            }
        }
    }
}
