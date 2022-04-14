pipeline {
    agent any
   
    environment {
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
               sh "dotnet build ${WORKSPACE}"
            }
        }
        stage('CodeAnalysis') {
            steps {
                 echo "The build number is ${env.BUILD_NUMBER}"
                echo "You can also use \${BUILD_NUMBER} -> ${BUILD_NUMBER}" 
                  echo "You can also use \${BUILD_NUMBER} -> ${WORKSPACE}" 
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
