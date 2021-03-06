﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.1
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OESUI.QuestionService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="QuestionService.IQuestionService")]
    public interface IQuestionService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IQuestionService/GetQuestionsByExamId", ReplyAction="http://tempuri.org/IQuestionService/GetQuestionsByExamIdResponse")]
        System.Collections.Generic.List<OESModel.Question> GetQuestionsByExamId(int examId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IQuestionService/GetQuestionAnswerByQuestionId", ReplyAction="http://tempuri.org/IQuestionService/GetQuestionAnswerByQuestionIdResponse")]
        int GetQuestionAnswerByQuestionId(int questionId);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IQuestionServiceChannel : OESUI.QuestionService.IQuestionService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class QuestionServiceClient : System.ServiceModel.ClientBase<OESUI.QuestionService.IQuestionService>, OESUI.QuestionService.IQuestionService {
        
        public QuestionServiceClient() {
        }
        
        public QuestionServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public QuestionServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public QuestionServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public QuestionServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public System.Collections.Generic.List<OESModel.Question> GetQuestionsByExamId(int examId) {
            return base.Channel.GetQuestionsByExamId(examId);
        }
        
        public int GetQuestionAnswerByQuestionId(int questionId) {
            return base.Channel.GetQuestionAnswerByQuestionId(questionId);
        }
    }
}
