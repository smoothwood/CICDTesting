node{
    
    stage('Echo'){
        echo 'Triggered by webhook.'
    }

    stage('SCM - Cloning'){
        echo 'Checking out code.'
        git 'https://github.com/smoothwood/CICDTesting.git'
    }
    
    stage('Build Application'){
        echo 'Building application.'
        sh 'dotnet build'
    }
    
    stage('Run Tests'){
        echo 'Running test cases.'
        sh 'dotnet test'
    }

    stage('Build Image'){
        echo 'Building image.'
        sh 'docker build -t ycmacr.azurecr.io/cicdtesting CICDTesting'
    }

    stage('Push Image'){
        withDockerRegistry(credentialsId: 'AzureContainerRegistry', url: 'https://ycmacr.azurecr.io') {
            echo 'Pushing Image.'
            sh 'docker push ycmacr.azurecr.io/cicdtesting'
        }
    }
}