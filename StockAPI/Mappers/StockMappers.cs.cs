using StockAPI.Dtos.Stock;
using StockAPI.Models;

namespace StockAPI.Mappers
{
    public static class StockMappers
    {
        public static StockDto ToStockDto(this Stock stockModel) 
        {
            return new StockDto { 
                Id = stockModel.Id,
                Symbol = stockModel.Symbol,
                CompanyName = stockModel.CompanyName,
                Purchase= stockModel.Purchase,
                LastDiv = stockModel.LastDiv,
                Industry=stockModel.Industry,
                MarketCap=stockModel.MarketCap
            };
        }

        public static Stock ToStockFromCreateDTO(this CreateStockRequestDto stockDto)
        {
            // mora biti stock jer nece prihvatiti kao dto
            return new Stock
            { 
                Symbol = stockDto.Symbol,
                CompanyName = stockDto.CompanyName,
                Purchase= stockDto.Purchase,
                LastDiv = stockDto.LastDiv,
                MarketCap =stockDto.MarketCap,
                Industry = stockDto.Industry
            };
        }
    }
}
