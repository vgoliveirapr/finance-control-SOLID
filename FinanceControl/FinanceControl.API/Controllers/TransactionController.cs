﻿using FinanceControl.Application.Factories;
using FinanceControl.Application.Interfaces;
using FinanceControl.Application.Services;
using FinanceControl.Domain.DTOs;
using Microsoft.AspNetCore.Mvc;

namespace FinanceControl.API.Controllers
{
    [ApiController]
    [Route("api/transactions")]
    public class TransactionController : Controller
    {
        private readonly TransactionServiceFactory factoryService;

        public TransactionController(TransactionServiceFactory factory)
        {
            factoryService = factory;
        }

        [HttpPost]
        public async Task<IActionResult> AddTransaction([FromBody] TransactionDTO transacao)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            ITransactionService Service = factoryService.CreateService(transacao.Type.ToString());
            await Service.AddNewTransaction(transacao);
            return Ok("Finantial transaction saved successfully");
        }

        [HttpGet]
        public async Task<IActionResult> GetAllTransactions([FromServices] DataRepositoryService repositoryData)
        {
            return Ok(await repositoryData.GetAllTransactions());
        }
    }
}
